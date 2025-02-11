﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrchardCore.Logging;
using System.Threading.Tasks;

namespace EasyOC.CMS.WebHost
{
    public class Program
    {
        public static Task Main(string[] args)
            => BuildWebHost(args).RunAsync();

        public static IHost BuildWebHost(string[] args) =>
           Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging => logging.ClearProviders())
                .ConfigureWebHostDefaults(webBuilder => webBuilder
                    .UseStartup<Startup>()
                    .UseNLogWeb()
                ).Build();

    }
}

