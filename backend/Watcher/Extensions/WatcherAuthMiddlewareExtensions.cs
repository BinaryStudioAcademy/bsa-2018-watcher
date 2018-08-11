namespace Watcher.Extensions
{
    using Microsoft.AspNetCore.Builder;

    using Watcher.Middlewares;

    public static class WatcherAuthMiddlewareExtensions
    {
        public static IApplicationBuilder UseWatcherAuth(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<WatcherAuthMiddleware>();
        }
    }
}
