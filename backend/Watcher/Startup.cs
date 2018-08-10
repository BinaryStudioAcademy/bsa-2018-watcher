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
    using Microsoft.Extensions.Logging;
    using Microsoft.IdentityModel.Tokens;

    using Watcher.Common.Options;
    using Watcher.Common.Validators;
    using Watcher.Core.Interfaces;
    using Watcher.Core.MappingProfiles;
    using Watcher.Core.Providers;
    using Watcher.Core.Services;
    using Watcher.DataAccess;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Interfaces;
    using Watcher.Extensions;
    using Watcher.Hubs;
    using Watcher.Utils;

    public class Startup
    {
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

            services.Configure<TimeServiceConfiguration>(Configuration.GetSection("TimeService"));

            var securitySection = Configuration.GetSection("Security");
            services.Configure<WatcherTokenOptions>(o =>
                {
                    o.Issuer = securitySection["Issuer"];
                    o.Audience = securitySection["Audience"];
                    o.Access_Token_Lifetime = Convert.ToInt32(securitySection["Access_Token_Lifetime"]);
                    o.Refresh_Token_Lifetime = Convert.ToInt32(securitySection["Refresh_Token_Lifetime"]);
                    o.Security_Key = securitySection["Security_Key"];
                });

            services.ConfigureSwagger(Configuration);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Add your services here
            services.AddTransient<ISamplesService, SamplesService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<ITokensService, TokensService>();
            services.AddTransient<IDashboardsService, DashboardsService>();
            services.AddTransient<ITransientService, TransientService>();
            services.AddTransient<IOrganizationService, OrganizationService>();  
            services.AddTransient<INotificationSettingsService, NotificationSettingsService>();
            services.AddTransient<IEmailProvider, EmailProvider>();
            
            ConfigureFileStorage(services, Configuration);

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

            var addSignalRBuilder = services.AddSignalR(o => o.EnableDetailedErrors = true);

            if (UseAzureSignalR)
            {
                addSignalRBuilder.AddAzureSignalR(
                    Configuration.GetConnectionString(ServiceOptions.ConnectionStringDefaultKey));
            }

            services.AddMvc()
                .AddFluentValidation(fv =>
                    {
                        fv.ImplicitlyValidateChildProperties = true;
                        // fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                        fv.RegisterValidatorsFromAssemblyContaining<SampleValidator>();
                        fv.RegisterValidatorsFromAssemblyContaining<OrganizationValidator>();
                    })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(MvcSetup.JsonSetupAction);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseHttpStatusCodeExceptionMiddleware();

            //UpdateDatabase(app);
            
            app.UseCors("CorsPolicy");

            app.UseHsts();
            app.UseConfiguredSwagger();
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
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

            app.UseMvc();
        }

        public virtual void ConfigureFileStorage(IServiceCollection services, IConfiguration configuration)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (enviroment == "Production")
            {
                var fileStorageString = Configuration.GetConnectionString("AzureFileStorageConnection");
                if (!string.IsNullOrWhiteSpace(fileStorageString))
                {
                    services.AddSingleton<IFileStorageProvider, FileStorageProvider>
                        (prov => new FileStorageProvider(fileStorageString));
                }
            }
            else
            {
                services.AddSingleton<IFileStorageProvider, LocalFileStorageProvider>
                        (prov => new LocalFileStorageProvider());
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

                    cfg.AddProfile<DashboardsProfile>();

                    cfg.AddProfile<OrganizationProfile>();
                    
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
