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
            host.Run();//׼��һ��web����������������
        }

        public static IHostBuilder CreateHostBuilder(string[] args) 
        {
            return
                Host.CreateDefaultBuilder(args)//����Ĭ��builder����ɸ�������
                .ConfigureLogging((context, LoggingBuilder) =>
                {
                    LoggingBuilder.AddFilter("system", LogLevel.Warning);//���˵������ռ�
                    LoggingBuilder.AddFilter("Microsoft", LogLevel.Warning);
                    LoggingBuilder.AddLog4Net();//ʹ��log4Net
                })
                .ConfigureWebHostDefaults(webBuilder =>//ָ��һ��web����������Kestrel
                {
                    webBuilder.UseStartup<Startup>();//��MVC���̴�����
                });
        }
            
    }
}
