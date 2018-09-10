using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.BusinessLayer.Services;
using DataAccumulator.BusinessLayer.Providers;
using DataAccumulator.BusinessLayer.Validators;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Repositories;
using DataAccumulator.DataAggregator;
using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.DataAggregator.Services;
using DataAccumulator.Shared.Models;
using DataAccumulator.WebAPI.TasksScheduler;
using DataAccumulator.WebAPI.Extensions;
using DataAccumulator.WebAPI.TasksScheduler.Jobs;
using ServiceBus.Shared.Queue;
using Quartz.Spi;

namespace DataAccumulator
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });

            var serviceBusSection = Configuration.GetSection("ServiceBus");
            services.Configure<AzureQueueSettings>(o =>
                {
                    o.ConnectionString = serviceBusSection["ConnectionString"];
                    o.DataQueueName = serviceBusSection["DataQueueName"];
                    o.ErrorQueueName = serviceBusSection["ErrorQueueName"];
                    o.SettingsQueueName = serviceBusSection["SettingsQueueName"];
                });

            services.AddTransient<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>();
            services.AddTransient<IDataAggregatorRepository<CollectedData>, DataAggregatorRepository>();
            services.AddTransient<IInstanceSettingsRepository<InstanceSettings>, InstanceSettingsRepository>();

            services.AddScoped<IDataAccumulatorService<CollectedDataDto>, DataAccumulatorService>();
            services.AddScoped<IDataAggregatorService<CollectedDataDto>, DataAggregatorService>();
            services.AddScoped<IInstanceSettingsService<InstanceSettingsDto>, InstanceSettingsService>();

            services.AddTransient<IAggregatorService<CollectedDataDto>, AggregatorService>();
            services.AddTransient<IDataAggregatorCore<CollectedDataDto>, DataAggregatorCore>();

            services.AddTransient<IThresholdsValidatorCore<CollectedDataDto>, ThresholdsValidatorCore>();

            services.AddTransient<ILogService, LogService>();
            services.AddTransient<ILogRepository, LogRepository>();

            services.AddTransient<IJobFactory, JobFactory>(
                (provider) =>
                {
                    return new JobFactory(provider);
                });

            services.AddTransient<CollectedDataAggregatingByHourJob>();
            services.AddTransient<CollectedDataAggregatingByDayJob>();
            services.AddTransient<CollectedDataAggregatingByWeekJob>();
            services.AddTransient<CollectedDataAggregatingByMonthJob>();

            services.AddTransient<IAzureQueueSender, AzureQueueSender>();
            services.AddSingleton<IServiceBusProvider, ServiceBusProvider>();

            // repo initialization localhost while development env, azure in prod
            ConfigureCosmosDb(services, Configuration);

            var mapper = MapperConfiguration().CreateMapper();
            services.AddTransient(_ => mapper);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime lifetime)
        {
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();

            app.UseHttpStatusCodeExceptionMiddleware();

            app.UseCors("CorsPolicy");
            
            app.UseMvc();

            app.UseQuartz((quartz) =>
            {
                if (Configuration.GetSection("DataAggregator").GetValue<bool>("Aggregating"))
                {
                    quartz.AddHourlyJob<CollectedDataAggregatingByHourJob>("CollectedDataAggregatingByHour", "DataAggregator");
                    quartz.AddDailyJob<CollectedDataAggregatingByDayJob>("CollectedDataAggregatingByDay", "DataAggregator");
                    quartz.AddWeeklyJob<CollectedDataAggregatingByWeekJob>("CollectedDataAggregatingByWeek", "DataAggregator");
                    quartz.AddMonthlyJob<CollectedDataAggregatingByMonthJob>("CollectedDataAggregatingByMonth", "DataAggregator");
                }
            });
        }
        public virtual void ConfigureCosmosDb(IServiceCollection services, IConfiguration configuration)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string connectionString = Configuration.GetConnectionString(enviroment == EnvironmentName.Production ? "AzureCosmosDbConnection" : "MongoDbConnection");

            services.AddTransient<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>(
                options => new DataAccumulatorRepository(connectionString, "bsa-watcher-data-storage", CollectedDataType.Accumulation));
            services.AddTransient<IDataAggregatorRepository<CollectedData>, DataAggregatorRepository>(
                options => new DataAggregatorRepository(connectionString, "bsa-watcher-data-storage"));
            services.AddTransient<ILogRepository, LogRepository>(
                options => new LogRepository(connectionString, "bsa-watcher-data-storage"));
        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CollectedData, CollectedDataDto>();
                cfg.CreateMap<CollectedDataDto, CollectedData>();
                cfg.CreateMap<CollectedData, CollectedData>();
                cfg.CreateMap<ActionLogDto, ActionLog>();
                cfg.CreateMap<InstanceSettings, InstanceSettingsDto>();
                cfg.CreateMap<InstanceSettingsDto, InstanceSettings>();
                cfg.CreateMap<InstanceSettings, InstanceSettings>();
            });

            return config;
        }
    }
}
