using AutoMapper;
using DataAccumulator.Entities;
using DataAccumulator.Interfaces;
using DataAccumulator.Models;
using DataAccumulator.Providers;
using DataAccumulator.Repositories;
using DataAccumulator.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

            services.Configure<Settings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                options.Database = Configuration.GetSection("MongoConnection:Database").Value;
            });

            services.AddTransient<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>();
            services.AddTransient<IServiceBusProvider, ServiceBusProvider>();
            services.AddScoped<IService<CollectedDataDto>, DataAccumulatorService>();

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
