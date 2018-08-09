namespace Watcher.Common.Options
{
    using System.Text;

    using Microsoft.IdentityModel.Tokens;

    public class WatcherTokenOptions
    {
        public WatcherTokenOptions()
        {
        }

        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int Access_Token_Lifetime { get; set; }
        public int Refresh_Token_Lifetime { get; set; }
        public string Security_Key { get; set; }

        public SymmetricSecurityKey GetSymmetricSecurityKey => new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Security_Key));

        public TokenValidationParameters GetRefreshTokenValidationParameters => new TokenValidationParameters
        {
            IssuerSigningKey = GetSymmetricSecurityKey,
            ValidateIssuerSigningKey = true,
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = false
        };

        public TokenValidationParameters GetAccessTokenValidationParameters => new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = Issuer,
            ValidateAudience = true,
            ValidAudience = Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = GetSymmetricSecurityKey,
            ValidateLifetime = true,
        };
    }
}
