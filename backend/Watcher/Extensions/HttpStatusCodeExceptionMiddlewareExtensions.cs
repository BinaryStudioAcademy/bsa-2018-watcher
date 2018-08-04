using Microsoft.AspNetCore.Builder;

namespace Watcher.Extensions
{
    using Watcher.Middlewares;

    public static class HttpStatusCodeExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseHttpStatusCodeExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpStatusCodeExceptionMiddleware>();
        }
    }
}