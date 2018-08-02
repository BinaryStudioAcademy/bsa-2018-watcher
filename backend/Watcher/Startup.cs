using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Watcher
{
    using AutoMapper;

    using FluentValidation.AspNetCore;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    using Watcher.Common.Validators;
    using Watcher.Core.Interfaces;
    using Watcher.Core.MappingProfiles;
    using Watcher.Core.Services;
    using Watcher.DataAccess;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Interfaces;
    using Watcher.Extensions;
    using Watcher.Utils;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader()
                           .AllowCredentials();
                }));

            services.ConfigureSwagger(Configuration);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<ISamplesService, SamplesService>();

            InitAutomapper(services);


            // Add framework services.
            ConfigureDatabase(services, Configuration);

            services.AddMvc()
                .AddFluentValidation(fv =>
                    {
                        fv.ImplicitlyValidateChildProperties = true;
                        // fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                        fv.RegisterValidatorsFromAssemblyContaining<SampleValidator>();
                    })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(MvcSetup.JsonSetupAction);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("CorsPolicy");

            app.UseHsts();

            app.UseHttpStatusCodeExceptionMiddleware();
            app.UseConfiguredSwagger();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMvc();
        }

        public virtual IServiceCollection InitAutomapper(IServiceCollection services)
        {
            // ServiceCollectionExtensions.UseStaticRegistration = false;

            services.AddAutoMapper(cfg =>
                {
                    cfg.AddProfile<SamplesProfile>();
                }); // Scoped Lifetime!
            // https://lostechies.com/jimmybogard/2016/07/20/integrating-automapper-with-asp-net-core-di/

            return services;
        }

        public virtual void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WatcherDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                                     b => b.MigrationsAssembly(configuration["MigrationsAssembly"])));
        }
    }
}
