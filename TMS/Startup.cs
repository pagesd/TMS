using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TMS.IRepository;
using TMS.Model;
using TMS.Repository;
using TMS.JWT;

namespace TMS
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// 配置
        /// </summary>
        public IConfiguration Configuration { get; }
        /// <summary>
        /// 配置
        /// </summary>
        /// <param name="services"></param>
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllers();
            //依赖注入  
            //jwt
            services.AddTransient<JWT_>();
            //显示
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TMS", Version = "v1" });
                var file = Path.Combine(AppContext.BaseDirectory, "D:\\物联网\\二\\TMS.UI\\TMS\\TMS.xml"); //xml文档的绝对路径
                var path = Path.Combine(AppContext.BaseDirectory, file);
                c.IncludeXmlComments(path, true); // true:显示控制器注释
                c.OrderActionsBy(o => o.RelativePath); //对action的名称排序,有多个的话就可以看到效果了

                #region swagger用JWT验证
                //开启权限小锁
                c.OperationFilter<AddResponseHeadersFilter>();
                c.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                //在header中添加token，传递到后台
                c.OperationFilter<SecurityRequirementsOperationFilter>();
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传递)直接在下面框中输入Bearer {token}(注意两者之间是一个空格) \"",
                    Name = "Authorization",// t默认的参数名称
                    In = ParameterLocation.Header,// t默认存放Authorization信息的位置(请求头中)
                    Type = SecuritySchemeType.ApiKey
                });
                #endregion


            });

            #region 添加JWT验证
            var jwtConfig = Configuration.GetSection("Jwt");
            //生成密钥
            var symmetricKeyAsBase64 = jwtConfig.GetValue<string>("Secret");
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBase64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);
            //认证参数
            services.AddAuthentication("Bearer")
                .AddJwtBearer(o =>
                {
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,//是否验证签名,不验证的话可以篡改数据，不安全
                        IssuerSigningKey = signingKey,//解密的密钥
                        ValidateIssuer = true,//是否验证发行人，就是验证载荷中的Iss是否对应ValidIssuer参数
                        ValidIssuer = jwtConfig.GetValue<string>("Iss"),//发行人
                        ValidateAudience = true,//是否验证订阅人，就是验证载荷中的Aud是否对应ValidAudience参数
                        ValidAudience = jwtConfig.GetValue<string>("Aud"),//订阅人
                        ValidateLifetime = true,//是否验证过期时间，过期了就拒绝访问
                        ClockSkew = TimeSpan.Zero,//这个是缓冲过期时间，也就是说，即使我们配置了过期时间，这里也要考虑进去，过期时间+缓冲，默认好像是7分钟，你可以直接设置为0
                        RequireExpirationTime = true,
                    };
                });
            #endregion

        }
        /// <summary>
        /// 配置文件
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TMS v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            //配置Cors
            app.UseCors(builder =>
            {
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();

                builder.AllowAnyOrigin();
            });
            //授权
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            

        }
        /// <summary>
        /// 自动依赖注入
        /// </summary>
        /// <param name="build"></param>
        public void ConfigureContainer(ContainerBuilder build)
        {
            var file = System.IO.Path.Combine(AppContext.BaseDirectory, "TMS.Repository.dll");
            build.RegisterAssemblyTypes(Assembly.LoadFile(file)).AsImplementedInterfaces();

        }

    }
}
