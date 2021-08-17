using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TMS.IRepository;
using TMS.Model;
using TMS.Repository;

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
        /// ����
        /// </summary>
        public IConfiguration Configuration { get; }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="services"></param>
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            //����ע��  
            //��¼
            //services.AddSingleton<TMSILogi, TMSLogin>();
            //��ʾ
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TMS", Version = "v1" });
                var file = Path.Combine(AppContext.BaseDirectory, "D:\\������\\��\\TMS.UI\\TMS\\TMS.xml"); //xml�ĵ��ľ���·��
                var path = Path.Combine(AppContext.BaseDirectory, file);
                c.IncludeXmlComments(path, true); // true:��ʾ������ע��
                c.OrderActionsBy(o => o.RelativePath); //��action����������,�ж���Ļ��Ϳ��Կ���Ч����
            });
        }
        /// <summary>
        /// �����ļ�
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
            //����Cors
            app.UseCors(builder =>
            {
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();

                builder.AllowAnyOrigin();
            });
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        /// <summary>
        /// �Զ�����ע��
        /// </summary>
        /// <param name="build"></param>
        public void ConfigureContainer(ContainerBuilder build)
        {

            var file = System.IO.Path.Combine(AppContext.BaseDirectory, "TMS.Repository.dll");
            build.RegisterAssemblyTypes(Assembly.LoadFile(file)).AsImplementedInterfaces();

        }
    }
}
