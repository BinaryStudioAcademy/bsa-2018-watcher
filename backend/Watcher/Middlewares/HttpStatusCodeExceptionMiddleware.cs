namespace Watcher.Middlewares
{
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;

    using Watcher.Common.Errors;

    public class HttpStatusCodeExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<HttpStatusCodeExceptionMiddleware> _logger;

        public HttpStatusCodeExceptionMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _logger = loggerFactory?.CreateLogger<HttpStatusCodeExceptionMiddleware>() ?? throw new ArgumentNullException(nameof(loggerFactory));
        }

        /// <summary>
        /// The invoke.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                if (context.Response.HasStarted)
                {
                    _logger.LogWarning(
                        "The response has already started, the http status code middleware will not be executed.");
                    throw;
                }

                context.Response.Clear();

                if (ex is HttpStatusCodeException httpException)
                {
                    if (httpException.StatusCode == HttpStatusCode.BadRequest)
                    {
                        context.Response.StatusCode = 452; // Custom status core for Client reasons
                    }
                    else
                    {
                        context.Response.StatusCode = (int)httpException.StatusCode;
                    }
                    context.Response.ContentType = httpException.ContentType;
                }
                else
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = @"application/json";
                    _logger.LogError(0, ex, "An unhandled exception has occurred: " + ex.Message);
                }

                var result = JsonConvert.SerializeObject(new ErrorResponse(ex.Message));

                await context.Response.WriteAsync(result);
            }
        }
    }
}
