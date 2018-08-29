namespace Watcher.Common.Helpers.Extensions
{
    using System.Linq;
    using System.Security.Claims;

    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            var name = user.Claims.FirstOrDefault(c => c.Type == ClaimsIdentity.DefaultNameClaimType);
            return name?.Value;
        }

        public static string GetUserEmail(this ClaimsPrincipal user)
        {
            var email = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);
            return email?.Value;
        }

        public static string GetUserRole(this ClaimsPrincipal user)
        {
            var email = user.Claims.FirstOrDefault(c => c.Type == ClaimsIdentity.DefaultRoleClaimType);
            return email?.Value;
        }
    }
}
