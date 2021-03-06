﻿using System;
using System.IO;
using System.Reflection;
using BlogDemo.Infrastructure.Database;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;

namespace BlogDemo.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File(Path.Combine("Logs", @"log.txt"), rollingInterval: RollingInterval.Day)
                .CreateLogger();


            var host = CreateWebHostBuilder(args).Build();
            ////向数据库添加数据
            //using (var scope = host.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;
            //    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            //    try
            //    {
            //        var myDBContext = services.GetRequiredService<MyDBContext>();
            //        MyDBContextSeed.SeedAsync(myDBContext, loggerFactory).Wait();
            //    }
            //    catch (Exception e)
            //    {
            //        var logger = loggerFactory.CreateLogger<Program>();
            //        logger.LogError(e, "向数据库Seed数据失败！");

            //        throw;
            //    }
            //}

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseStartup<Startup>();
                .UseStartup(typeof(StartupDevelopment).GetTypeInfo().Assembly.FullName)
               .UseSerilog();
    }
}
