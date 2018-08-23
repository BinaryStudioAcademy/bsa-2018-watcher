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
using DataAccumulator.Interfaces;
using DataAccumulator.Providers;
using DataAccumulator.Shared.Models;
using DataAccumulator.WebAPI.Jobs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
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

            services.AddMvc();

            services.AddSingleton<IQueueClient>(s => new QueueClient(
                Configuration.GetSection("SERVICE_BUS_CONNECTION_STRING").Value, 
                Configuration.GetSection("SERVICE_BUS_QUEUE_NAME").Value));
            services.AddSingleton<IServiceBusProvider, ServiceBusProvider>();

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

            
            // repo initialization localhost while development env, azure in prod
            ConfigureCosmosDb(services, Configuration);

            var mapper = MapperConfiguration().CreateMapper();
            services.AddTransient(_ => mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime lifetime)
        {
            app.UseCors("CorsPolicy");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
            if (enviroment == EnvironmentName.Production)
            {
                var cosmosDbString = Configuration.GetConnectionString("AzureCosmosDbConnection");
                if (!string.IsNullOrWhiteSpace(cosmosDbString))
                {
                    services.AddTransient<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>(
                          options => new DataAccumulatorRepository(cosmosDbString, "DataAccumulatorDb"));
                    services.AddTransient<IDataAggregatorRepository<CollectedData>, DataAggregatorRepository>(
                        options => new DataAggregatorRepository(cosmosDbString, "DataAccumulatorDb"));
                }
            }
            else
            {
                var mongoDbString = Configuration.GetConnectionString("MongoDbConnection");
                services.AddTransient<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>(
                          options => new DataAccumulatorRepository(mongoDbString, "DataAccumulatorDb"));
                services.AddTransient<IDataAggregatorRepository<CollectedData>, DataAggregatorRepository>(
                    options => new DataAggregatorRepository(mongoDbString, "DataAccumulatorDb"));
            }
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
