using System;
using AutoMapper;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.BusinessLayer.Services;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Repositories;
using DataAccumulator.DataAggregator;
using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.DataAggregator.Services;
using DataAccumulator.Shared.Models;
using DataAccumulator.WebAPI.Jobs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Quartz.Spi;

namespace DataAccumulator
{
    using DataAccumulator.BusinessLayer.Providers;
    using DataAccumulator.WebAPI.Extensions;

    using Microsoft.AspNetCore.Mvc;

    using ServiceBus.Shared.Queue;

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
                });

            services.AddTransient<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>();
            services.AddTransient<IDataAggregatorRepository<CollectedData>, DataAggregatorRepository>();

            services.AddScoped<IDataAccumulatorService<CollectedDataDto>, DataAccumulatorService>();
            services.AddScoped<IDataAggregatorService<CollectedDataDto>, DataAggregatorService>();

            services.AddTransient<IAggregatorService<CollectedDataDto>, AggregatorService>();
            services.AddTransient<IDataAggregatorCore<CollectedDataDto>, DataAggregatorCore>();

            services.AddTransient<IJobFactory, JobFactory>(
                (provider) =>
                {
                    return new JobFactory(provider);
                });

            services.AddTransient<CollectedDataAggregatingJob>();

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
                    quartz.AddJob<CollectedDataAggregatingJob>("DataAggregator", "Import", Configuration.GetSection("DataAggregator").GetValue<int>("IntervalMinute"));
            });
        }
        public virtual void ConfigureCosmosDb(IServiceCollection services, IConfiguration configuration)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string connectionString = Configuration.GetConnectionString(enviroment == EnvironmentName.Production ? "AzureCosmosDbConnection" : "MongoDbConnection");

            services.AddTransient<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>(
                options => new DataAccumulatorRepository(connectionString, "bsa-watcher-data-storage", CollectedDataType.Accumulation));
            services.AddTransient<IDataAggregatorRepository<CollectedData>, DataAggregatorRepository>(
                options => new DataAggregatorRepository(connectionString, "bsa-watcher-data-storage", CollectedDataType.AggregationForHour));

        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CollectedData, CollectedDataDto>();
                cfg.CreateMap<CollectedDataDto, CollectedData>();
                cfg.CreateMap<CollectedData, CollectedData>();
            });

            return config;
        }
    }
}
