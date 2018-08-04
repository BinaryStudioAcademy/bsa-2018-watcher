using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Watcher.Notifications
{
    using Microsoft.Azure.SignalR;

    using Watcher.Notifications.Hubs;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public bool UseAzureSignalR => Configuration[ServiceOptions.ConnectionStringDefaultKey] != null;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                }));

            services.AddMvc();

            var addSignalRBuilder = services.AddSignalR(o => o.EnableDetailedErrors = true);

            if (UseAzureSignalR)
            {
                addSignalRBuilder.AddAzureSignalR();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("CorsPolicy");
            app.UseMvc();
            app.UseFileServer();

            if (UseAzureSignalR)
            {
                app.UseAzureSignalR(routes =>
                    {
                        routes.MapHub<Chat>("/chat");
                        routes.MapHub<NotificationsHub>("/notifications");
                    });
            }
            else
            {
                app.UseSignalR(routes =>
                    {
                        routes.MapHub<Chat>("/chat");
                        routes.MapHub<NotificationsHub>("/notifications");
                    });
            }
        }
    }
}
