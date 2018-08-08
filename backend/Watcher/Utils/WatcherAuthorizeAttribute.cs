namespace Watcher.Utils
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Security.Claims;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    using Watcher.Core.Auth;
    using Watcher.Core.Services;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class WatcherAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private const string key = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1"; // TODO: Transfer if to the Client (user) secrets

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
                // context.Result = new UnauthorizedResult();
                return;
            }

            // you can also use registered services
            // var someService = context.HttpContext.RequestServices.GetService<ISomeService>(); // TODO: Inject Options Here

            if (!context.HttpContext.Request.Headers.TryGetValue("WatcherAuthorize", out var values))
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.Unauthorized);
                return;
            }

            var jwt = TokenUtil.GetDecodedJwt(values.FirstOrDefault(), TokenUtil.GetAccessTokenValidationParameters(key), key);

            var role = jwt.Claims.FirstOrDefault(claim => claim.Type == "role" && claim.Value == _role);
            var name = jwt.Claims.FirstOrDefault(claim => claim.Type == "name");

            if (role != null && name != null)
            {
                var identity = TokensService.CreateDefaultClaimsIdentity(jwt.Claims);
                user.AddIdentity(identity);
            }
            else
            {
                context.Result = new StatusCodeResult((int)HttpStatusCode.Forbidden);
            }
        }
    }
}
