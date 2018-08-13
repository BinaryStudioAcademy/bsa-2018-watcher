namespace Watcher.Common.Helpers.Extensions
{
    using System.Linq;
    using System.Security.Claims;

    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            var name = user.Claims.FirstOrDefault(c => c.Type == "unique_name");
            return name?.Value;
        }

        public static string GetUserEmail(this ClaimsPrincipal user)
        {
            var email = user.Claims.FirstOrDefault(c => c.Type == "email");
            return email?.Value;
        }
    }
}
