using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMS
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //����
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

            //ʹ��Nlog��Ϊ��־��¼
            builder.ConfigureLogging(logging =>
            {
                //���ԭ�е���־��
                logging.ClearProviders();
            }).UseNLog();

            return builder;
        }
            
    }
}
