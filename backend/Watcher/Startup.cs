namespace Watcher
{
    using System;

    using AutoMapper;

    using FluentValidation.AspNetCore;

    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.SignalR;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.IdentityModel.Tokens;
    using Watcher.Common.Validators;
    using Watcher.Core.Interfaces;
    using Watcher.Core.MappingProfiles;
    using Watcher.Core.Services;
    using Watcher.DataAccess;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Interfaces;
    using Watcher.Extensions;
    using Watcher.Hubs;
    using Watcher.Utils;

    public class Startup
    {
        private const string key = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1"; // TODO: Transfer if to the Client (user) secrets

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public bool UseAzureSignalR => !string.IsNullOrWhiteSpace(Configuration.GetConnectionString(ServiceOptions.ConnectionStringDefaultKey));

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

            // Add your services here
            services.AddTransient<ISamplesService, SamplesService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<ITokensService, TokensService>();


            services.AddTransient<ITransientService, TransientService>();

            // It's Singleton so we can't consume Scoped services & Transient services that consume Scoped services
            // services.AddHostedService<WatcherService>();

            InitializeAutomapper(services);

            ConfigureDatabase(services, Configuration);

            services.AddAuthentication(o =>
                    {
                        o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                        o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    })
                    .AddJwtBearer(options =>
                    {
                        options.Authority = "https://securetoken.google.com/watcherapp-2984b";
                        options.TokenValidationParameters =
                            new TokenValidationParameters
                            {
                                ValidateIssuer = true,
                                ValidIssuer =
                                        "https://securetoken.google.com/watcherapp-2984b",
                                ValidateAudience = true,
                                ValidAudience = "watcherapp-2984b",
                                ValidateLifetime = true
                            };
                    });

            services.AddMvc()
                .AddFluentValidation(fv =>
                    {
                        fv.ImplicitlyValidateChildProperties = true;
                        // fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                        fv.RegisterValidatorsFromAssemblyContaining<SampleValidator>();
                    })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(MvcSetup.JsonSetupAction);

            var addSignalRBuilder = services.AddSignalR(o => o.EnableDetailedErrors = true);

            if (UseAzureSignalR)
            {
                addSignalRBuilder.AddAzureSignalR(
                    Configuration.GetConnectionString(ServiceOptions.ConnectionStringDefaultKey));
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseHttpStatusCodeExceptionMiddleware();

            UpdateDatabase(app);

            // TODO: Use Authorization
            app.UseCors("CorsPolicy");

            app.UseHsts();
            app.UseConfiguredSwagger();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc();
            app.UseFileServer();

            if (UseAzureSignalR)
            {
                app.UseAzureSignalR(routes =>
                    {
                        routes.MapHub<NotificationsHub>("/notifications");
                    });
            }
            else
            {
                app.UseSignalR(routes =>
                    {
                        routes.MapHub<NotificationsHub>("/notifications");
                    });
            }
        }

        public virtual IServiceCollection InitializeAutomapper(IServiceCollection services)
        {
            // Used in older versions
            // ServiceCollectionExtensions.UseStaticRegistration = false;

            services.AddAutoMapper(cfg =>
                {
                    cfg.AddProfile<SamplesProfile>();
                    cfg.AddProfile<UsersProfile>();
                }); // Scoped Lifetime!
            // https://lostechies.com/jimmybogard/2016/07/20/integrating-automapper-with-asp-net-core-di/

            return services;
        }

        public virtual void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
            // Use SQL Database if in Azure, otherwise, use Local DB
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (env == "Production")
            {
                var azureConnStr = Configuration.GetConnectionString("AzureDbConnection");
                if (!string.IsNullOrWhiteSpace(azureConnStr))
                {
                    services.AddDbContext<WatcherDbContext>(options => options.UseSqlServer(azureConnStr,
                        b => b.MigrationsAssembly(configuration["MigrationsAssembly"])));
                }
            }
            else
            {
                services.AddDbContext<WatcherDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                                         b => b.MigrationsAssembly(configuration["MigrationsAssembly"])));
            }
        }

        private static void UpdateDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<WatcherDbContext>())
                {
                    context?.Database?.Migrate();
                }
            }
        }
    }
}
