using DataAccumulator.Shared.Models;

namespace Watcher
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using AutoMapper;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;
    using DataAccumulator.DataAccessLayer.Repositories;

    using FluentValidation.AspNetCore;

    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.SignalR;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.FileProviders;
    using Microsoft.Extensions.Logging;
    using Microsoft.IdentityModel.Tokens;

    using Newtonsoft.Json;

    using ServiceBus.Shared.Queue;

    using Watcher.Common.Options;
    using Watcher.Common.Validators;
    using Watcher.Core.Hubs;
    using Watcher.Core.Interfaces;
    using Watcher.Core.MappingProfiles;
    using Watcher.Core.Providers;
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

            var serviceBusSection = Configuration.GetSection("ServiceBus");
            services.Configure<AzureQueueSettings>(o =>
                {
                    o.ConnectionString = serviceBusSection["ConnectionString"];
                    o.DataQueueName = serviceBusSection["DataQueueName"];
                    o.ErrorQueueName = serviceBusSection["ErrorQueueName"];
                    o.SettingsQueueName = serviceBusSection["SettingsQueueName"];
                    o.NotifyQueueName = serviceBusSection["NotifyQueueName"];
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
            services.AddTransient<IChatsService, ChatsService>();
            services.AddTransient<IMessagesService, MessagesService>();
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<INotificationSettingsService, NotificationSettingsService>();
            services.AddTransient<IEmailProvider, EmailProvider>();
            services.AddTransient<IInstanceService, InstanceService>();
            services.AddTransient<IFeedbackService, FeedbackService>();
            services.AddTransient<IChartsService, ChartsService>();
            services.AddTransient<IResponseService, ResponseService>();
            services.AddTransient<IOrganizationInvitesService, OrganizationInvitesService>();
            services.AddTransient<ICollectedDataService, CollectedDataService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IOrganizationRoleService, OrganizationRoleService>();
            services.AddTransient<IUserOrganizationService, UserOrganizationService>();
            services.AddTransient<IAggregateDataService, AggregatedDataService>();
            services.AddTransient<ICollectorActionLogService, CollectorActionLogService>();
<<<<<<< HEAD
            services.AddTransient<ICollectorAppsService, CollectorAppsService>();
=======
            services.AddTransient<IThemeService, ThemeService>();
>>>>>>> dev

            services.AddTransient<IAzureQueueReceiver, AzureQueueReceiver>();
            services.AddTransient<IAzureQueueSender, AzureQueueSender>();
            services.AddSingleton<IServiceBusProvider, ServiceBusProvider>();
            
            // repo initialization localhost while development env, azure in prod
            ConfigureCosmosDb(services, Configuration);

            ConfigureFileStorage(services, Configuration);

            // It's Singleton so we can't consume Scoped services & Transient services that consume Scoped services
            // services.AddHostedService<WatcherService>();

            var imageFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
            Directory.CreateDirectory(imageFolder);

            services.AddSingleton<IFileProvider>(
                new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images")));

            InitializeAutomapper(services);

            ConfigureDatabase(services, Configuration);

            services.AddAuthentication(o =>
                    {
                        o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                        o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    })
                    .AddJwtBearer(options =>
                    {
                        options.Events = new JwtBearerEvents()
                        {
                            OnMessageReceived = delegate (MessageReceivedContext context)
                              {
                                  if ((!context.Request.Path.Value.Contains("/notifications")
                                      && !context.Request.Path.Value.Contains("/dashboards")
                                      && !context.Request.Path.Value.Contains("/chatsHub")
                                      && !context.Request.Path.Value.Contains("/invites"))

                                      || !context.Request.Query.ContainsKey("Authorization")
                                      || !context.Request.Query.ContainsKey("WatcherAuthorization"))
                                      return Task.CompletedTask;

                                  // context.Token = context.Request.Query["Authorization"];
                                  var watcherToken = context.Request.Query["WatcherAuthorization"];
                                  var firebaseToken = $"Bearer {context.Request.Query["Authorization"]}";
                                  context.Request.Headers.TryAdd("Authorization", firebaseToken);
                                  context.Request.Headers.TryAdd("WatcherAuthorization", watcherToken);

                                  return Task.CompletedTask;
                              }
                        };

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

            services.AddAuthorization(o =>
                {
                    // TODO: create Policy

                    o.AddPolicy("SomePolicy", b =>
                        {
                            b.RequireAuthenticatedUser();
                        });
                    o.AddPolicy("AdminPolicy", b =>
                        {
                            b.RequireAuthenticatedUser();
                            b.RequireClaim(ClaimTypes.Role, "Admin");
                            b.AuthenticationSchemes = new List<string> { JwtBearerDefaults.AuthenticationScheme };
                        });
                });

            var addSignalRBuilder = services.AddSignalR(o => o.EnableDetailedErrors = true) // .AddAzureService()
                .AddJsonProtocol(options => options.PayloadSerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

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
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IFileProvider fileProvider)
        {
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();

            app.UseHttpStatusCodeExceptionMiddleware();

            UpdateDatabase(app);

            app.UseCors("CorsPolicy");
            app.UseHsts();
            app.UseConfiguredSwagger();
            app.UseHttpsRedirection();

            app.UseDefaultFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = fileProvider
            });
            app.UseFileServer();

            app.UseAuthentication();

            app.UseWatcherAuth();

            app.UseMvc();

            if (UseAzureSignalR)
            {
                app.UseAzureSignalR(routes =>
                    {
                        routes.MapHub<NotificationsHub>("/notifications");
                        routes.MapHub<DashboardsHub>("/dashboards");
                        routes.MapHub<InvitesHub>("/invites");
                        routes.MapHub<ChatsHub>("/chatsHub");
                    });
            }
            else
            {
                app.UseSignalR(routes =>
                    {
                        routes.MapHub<NotificationsHub>("/notifications");
                        routes.MapHub<DashboardsHub>("/dashboards");
                        routes.MapHub<InvitesHub>("/invites");
                        routes.MapHub<ChatsHub>("/chatsHub");
                    });
            }

            app.UseMvc();

            var provider = app.ApplicationServices.GetService<IServiceBusProvider>();
        }

        public virtual void ConfigureCosmosDb(IServiceCollection services, IConfiguration configuration)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string connectionString = configuration.GetConnectionString(enviroment == EnvironmentName.Production ? "AzureCosmosDbConnection" : "MongoDbConnection");

            services.AddScoped<IDataAccumulatorRepository<CollectedData>, DataAccumulatorRepository>(
                  options => new DataAccumulatorRepository(connectionString, "bsa-watcher-data-storage", CollectedDataType.Accumulation));

            services.AddScoped<IDataAggregatorRepository<CollectedData>, DataAggregatorRepository>(
                options => new DataAggregatorRepository(connectionString, "bsa-watcher-data-storage"));
            services.AddScoped<ILogRepository, LogRepository>(
                    options => new LogRepository(connectionString, "bsa-watcher-data-storage"));
        }

        public virtual void ConfigureFileStorage(IServiceCollection services, IConfiguration configuration)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (enviroment == EnvironmentName.Production)
            {
                var fileStorageString = configuration.GetConnectionString("AzureFileStorageConnection");
                if (!string.IsNullOrWhiteSpace(fileStorageString))
                {
                    services.AddScoped<IFileStorageProvider, FileStorageProvider>(
                        prov => new FileStorageProvider(fileStorageString));
                }
            }
            else
            {
                services.AddScoped<IFileStorageProvider, LocalFileStorageProvider>(
                    prov => new LocalFileStorageProvider());
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
                    cfg.AddProfile<UserOrganizationProfile>();

                    cfg.AddProfile<NotificationSettingsProfile>();


                    cfg.AddProfile<ChatProfile>();

                    cfg.AddProfile<MessageProfile>();

                    cfg.AddProfile<FeedbackProfile>();
                    cfg.AddProfile<RoleProfile>();
                    cfg.AddProfile<ResponseProfile>();
                    cfg.AddProfile<InstancesProfile>();
                    cfg.AddProfile<OrganizationInvitesProfile>();
                    cfg.AddProfile<CollectedDataProfile>();
                    cfg.AddProfile<CollectorActionLogProfile>();
                    cfg.AddProfile<ThemeProfile>();

                }); // Scoped Lifetime!
            // https://lostechies.com/jimmybogard/2016/07/20/integrating-automapper-with-asp-net-core-di/

            return services;
        }


        public virtual void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
            // Use SQL Database if in Azure, otherwise, use Local DB
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (env == EnvironmentName.Production)
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
