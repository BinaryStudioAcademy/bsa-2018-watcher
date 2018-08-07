namespace Watcher.Core.Auth
{
    using System.Text;

    using Microsoft.IdentityModel.Tokens;

    public class AuthOptions
    {
        public const string Issuer = "Watcher_Web_App";
        public const string Audience = "Watcher_Client";
        public const int Access_token_Lifetime = 999; // 999 minutes // TODO: Change after tests
        public const int Refresh_token_Lifetime = 999; // 999 days // TODO: Change after tests

        public static SymmetricSecurityKey GetSymmetricSecurityKey(string securityKey) => new SymmetricSecurityKey(Encoding.ASCII.GetBytes(securityKey));
    }
}
