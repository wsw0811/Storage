using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Storage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args);
            var host = hostBuilder.Build();
            host.Run();//准备一个web服务器并运行起来
        }

        public static IHostBuilder CreateHostBuilder(string[] args) 
        {
            return
                Host.CreateDefaultBuilder(args)//创建默认builder会完成各种配置
                .ConfigureLogging((context, LoggingBuilder) =>
                {
                    LoggingBuilder.AddFilter("system", LogLevel.Warning);//过滤掉命名空间
                    LoggingBuilder.AddFilter("Microsoft", LogLevel.Warning);
                    LoggingBuilder.AddLog4Net();//使用log4Net
                })
                .ConfigureWebHostDefaults(webBuilder =>//指定一个web服务器——Kestrel
                {
                    webBuilder.UseStartup<Startup>();//跟MVC流程串起来
                });
        }
            
    }
}
