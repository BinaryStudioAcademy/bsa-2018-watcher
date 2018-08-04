namespace Watcher
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore.Internal;
    using Microsoft.Extensions.Configuration;

    using Watcher.Common.Enums;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.Extensions;

    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build().Migrate<WatcherDbContext>(SeedAction);

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        var env = hostingContext.HostingEnvironment;
                        config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                        config.AddEnvironmentVariables();
                    })
                .UseIISIntegration()
                .UseStartup<Startup>();

        /// <summary>
        /// The seed action.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public static void SeedAction(WatcherDbContext context)
        {
            if (!context.Samples.Any())
            {
                var samples = new List<Sample>()
                {
                    new Sample()
                    {
                        Name = "First Sample",
                        Count = 12,
                        CreationDate = new DateTime(2002, 1, 2),
                        SampleField = SampleEnum.FirstItem
                    },
                    new Sample()
                    {
                        Name = "Second Sample",
                        Count = 14,
                        CreationDate = new DateTime(2001, 1, 2),
                        SampleField = SampleEnum.ThirdItem
                    },
                    new Sample()
                    {
                        Name = "Third Sample",
                        Count = 50,
                        CreationDate = new DateTime(2005, 11, 20),
                        SampleField = SampleEnum.SecondItem
                    },
                    new Sample()
                    {
                        Name = "Forth Sample",
                        Count = 10,
                        CreationDate = new DateTime(2002, 10, 12),
                        SampleField = SampleEnum.ThirdItem
                    },
                    new Sample()
                    {
                        Name = "Fifth Sample",
                        Count = 6,
                        CreationDate = new DateTime(1998, 2, 3),
                        SampleField = SampleEnum.FirstItem
                    }
                };

                context.Samples.AddRange(samples);
                context.SaveChanges();
            }
        }
    }
}
