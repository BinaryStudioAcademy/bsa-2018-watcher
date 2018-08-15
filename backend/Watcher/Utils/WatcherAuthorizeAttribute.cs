namespace Watcher.Utils
{
    using System;
    using System.Linq;
    using System.Net;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Options;
    using Watcher.Common.Options;
    using Watcher.Core.Auth;

    /// <summary>
    /// Found a better more flexible way
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class WatcherAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly string _role;

        public WatcherAuthorizeAttribute(string role)
        {
            _role = role;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            if (!user.Identity.IsAuthenticated)
            {
                // it isn't needed to set unauthorized result 
                // as the base class already requires the user to be authenticated
                // this also makes redirect to a login page work properly
                context.Result = new UnauthorizedResult();
                return;
            }

            // you can also use registered services
            var tokenOptions = context.HttpContext.RequestServices.GetService<IOptions<WatcherTokenOptions>>();
            

            if (!context.HttpContext.Request.Headers.TryGetValue("WatcherAuthorization", out var values))
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.Forbidden);
                return;
            }

            var jwt = TokenUtil.GetDecodedJwt(values.FirstOrDefault(), 
                                              tokenOptions.Value.GetAccessTokenValidationParameters);

            var role = jwt.Claims.FirstOrDefault(claim => claim.Type == "role" && claim.Value == _role);
            var name = jwt.Claims.FirstOrDefault(claim => claim.Type == "unique_name");

            if (role != null && name != null)
            {
                var identity = TokenUtil.CreateDefaultClaimsIdentity(jwt.Claims);
                user.AddIdentity(identity);
            }
            else
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.Forbidden);
            }
        }
    }
}
