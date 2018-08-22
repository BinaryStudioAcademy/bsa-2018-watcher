﻿using AutoMapper;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.BusinessLayer.Services;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Repositories;
using DataAccumulator.Interfaces;
using DataAccumulator.Providers;
using DataAccumulator.Shared.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

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

            services.AddSingleton<IQueueClient>( s => new QueueClient(Configuration.GetSection("SERVICE_BUS_CONNECTION_STRING").Value, Configuration.GetSection("SERVICE_BUS_QUEUE_NAME").Value) );
            services.AddSingleton<IServiceBusProvider, ServiceBusProvider>();

            services.AddScoped<IService<CollectedDataDto>, DataAccumulatorService>();

            
            // repo initialization localhost while development env, azure in prod
            ConfigureCosmosDb(services, Configuration);

            var mapper = MapperConfiguration().CreateMapper();
            services.AddTransient(_ => mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("CorsPolicy");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
        public virtual void ConfigureCosmosDb(IServiceCollection services, IConfiguration configuration)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (enviroment == EnvironmentName.Production)
            {
                var cosmosDbString = Configuration.GetConnectionString("AzureCosmosDbConnection");
                if (!string.IsNullOrWhiteSpace(cosmosDbString))
                {
                    services.AddScoped<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>(
                          options => new DataAccumulatorRepository(cosmosDbString, "DataAccumulatorDb"));
                }
            }
            else
            {
                var mongoDbString = Configuration.GetConnectionString("MongoDbConnection");
                services.AddScoped<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>(
                          options => new DataAccumulatorRepository(mongoDbString, "DataAccumulatorDb"));
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
