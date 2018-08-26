namespace DataAccumulator.WebAPI.Extensions
{
    using DataAccumulator.WebAPI.Middlewares;

    using Microsoft.AspNetCore.Builder;

    public static class HttpStatusCodeExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseHttpStatusCodeExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpStatusCodeExceptionMiddleware>();
        }
    }
}