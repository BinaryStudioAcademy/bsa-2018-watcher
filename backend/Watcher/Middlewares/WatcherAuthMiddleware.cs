namespace Watcher.Middlewares
{
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Net;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using Serilog.Context;

    using Watcher.Common.Errors;
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
                JwtSecurityToken jwt = null;
                try
                {
                    jwt = TokenUtil.GetDecodedJwt(watcherToken, tokenOptions.Value.GetAccessTokenValidationParameters);
                }
                catch (Exception e)
                {
                    var eventId = new EventId(403);
                    using (LogContext.PushProperty("LogEventId", eventId.Id))
                    {
                        _logger.LogError(eventId, e, $"Watcher Token was not validated: {e.Message}");
                    }
                    throw new HttpStatusCodeException(HttpStatusCode.Forbidden, "Watcher Token was not validated");
                }

                var role = jwt.Claims.Any(c => c.Type == "role");
                var name = jwt.Claims.Any(c => c.Type == "unique_name");
                if (role && name)
                {
                    var identity = new ClaimsIdentity(jwt.Claims, "Token", "unique_name", "role");

                    context.User.AddIdentity(identity);
                }

                await _next.Invoke(context);
            }
        }
    }
}
