namespace DataAccumulator.WebAPI.Middlewares
{
    using System;
    using System.Net;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Logging;

    using Newtonsoft.Json;

    using Serilog.Context;

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
                    var name = "response has already started";
                    var eventId = new EventId(509, name);
                    using (LogContext.PushProperty("LogEventId", eventId.Id))
                    using (LogContext.PushProperty("ClassName", this.GetType().FullName))
                    using (LogContext.PushProperty("Source", ex.Source))
                    {
                        _logger.LogError(eventId, ex, "Error: the {name}, the http status code middleware will not be executed.", name);
                    }

                    throw;
                }

                context.Response.Clear();

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json; charset=utf-8";

                var errorEventId = new EventId(500, "An unhandled exception");
                using (LogContext.PushProperty("LogEventId", errorEventId.Id))
                using (LogContext.PushProperty("ClassName", this.GetType().FullName))
                using (LogContext.PushProperty("Source", ex.Source))
                {
                    _logger.LogError(errorEventId, ex, "An unhandled exception has occurred: " + ex.Message);
                }

                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                var result = JsonConvert.SerializeObject(ex);

                await context.Response.WriteAsync(result);
            }
        }
    }
}
