namespace Watcher.Extensions
{
    using System;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class MigrationsExtension
    {
        public static IWebHost Migrate<T>(this IWebHost webhost, Action<T> seedAction = null) where T : DbContext, IDisposable
        {
            using (var scope = webhost.Services.GetService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<T>())
                {
                    try
                    {
                        // TODO: fix
                        context?.Database?.Migrate();
                    }
                    catch (Exception ex)
                    {
                        //context?.Database?.EnsureDeleted();
                        //context?.Database?.Migrate();
                    }

                    seedAction?.Invoke(context);
                }
            }

            return webhost;
        }
    }
}
