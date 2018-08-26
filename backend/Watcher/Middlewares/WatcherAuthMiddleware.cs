namespace Watcher.Middlewares
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using Watcher.Common.Options;
    using Watcher.Core.Auth;

    public class WatcherAuthMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<WatcherAuthMiddleware> _logger;

        public WatcherAuthMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _logger = loggerFactory?.CreateLogger<WatcherAuthMiddleware>() ?? throw new ArgumentNullException(nameof(loggerFactory));
        }

        /// <summary>
        /// Exetuted after JWT Authentication Middleware so we already have Firebase Identity and Claims
        /// We set WatcherAuthorize header with out Token in OnMessageReceived so we need add its Identity to Current Principal (User)
        /// </summary>
        /// <param name="context">Http Context</param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            var tokenOptions = context.RequestServices.GetService<IOptions<WatcherTokenOptions>>();

            var watcherToken = context.Request.Headers["WatcherAuthorization"];

            if (string.IsNullOrWhiteSpace(watcherToken))
            {
                await _next.Invoke(context);
            }
            else
            {
                var jwt = TokenUtil.GetDecodedJwt(watcherToken, tokenOptions.Value.GetAccessTokenValidationParameters);

                if (jwt != null)
                {
                    var role = jwt.Claims.Any(c => c.Type == "role");
                    var name = jwt.Claims.Any(c => c.Type == "unique_name");
                    if (role && name)
                    {
                        var identity = new ClaimsIdentity(jwt.Claims, "Token", "unique_name", "role");

                        context.User.AddIdentity(identity);
                    }

                    await _next.Invoke(context);
                }
                else
                {
                    context.Response.Clear();
                    context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                    context.Response.ContentType = "application/json; charset=utf-8";
                    context.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                    var result = "Watcher JWT token was not validated";

                    await context.Response.WriteAsync(result);
                }
            }
        }
    }
}
