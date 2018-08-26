using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DataAccumulator
{
    using System;
    using System.IO;

    using Microsoft.Extensions.Configuration;
    using Microsoft.WindowsAzure.Storage;

    using Serilog;
    using Serilog.Events;

    public class Program
    {
        public static IConfiguration Configuration { get; } = GetConfigurationRoot();

        private static IConfigurationRoot GetConfigurationRoot()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? EnvironmentName.Production}.json", optional: true)
                .AddEnvironmentVariables();
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == EnvironmentName.Development)
            {
                configurationBuilder.AddUserSecrets<Program>(false);
            }

            return configurationBuilder.Build();
        }


        public static int Main(string[] args)
        {
            var outputTemplate = "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{properties}{NewLine}";

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == EnvironmentName.Production)
            {
                var connectionString = Configuration.GetConnectionString("LogsConnection");
                var storageAccount = CloudStorageAccount.Parse(connectionString);
                Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(Configuration)
                    .Enrich.FromLogContext()
                    .WriteTo.Console(outputTemplate: outputTemplate)
                    .WriteTo.AzureTableStorageWithProperties(storageAccount,
                        LogEventLevel.Warning,
                        storageTableName: "logs-table",
                        writeInBatches: true,
                        batchPostingLimit: 100,
                        period: new TimeSpan(0, 0, 3),
                        propertyColumns: new[] { "LogEventId" }).CreateLogger();
            }
            else
            {
                Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(Configuration)
                    .Enrich.FromLogContext()
                    .WriteTo.Console(outputTemplate: outputTemplate)
                    .CreateLogger();
            }

            try
            {
                Log.Information("Starting BSA Watcher Web App...");

                BuildWebHost(args).Run();

                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseSetting("detailedErrors", "true")
                .UseConfiguration(Configuration)
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseSerilog()
                .CaptureStartupErrors(true)
                .Build();
    }
}
