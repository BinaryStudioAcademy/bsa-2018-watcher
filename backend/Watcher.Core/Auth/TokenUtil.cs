namespace Watcher.Core.Auth
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Net;

    using Microsoft.IdentityModel.Tokens;

    using Watcher.Common.Errors;

    public class TokenUtil // Maybe make this class Signleton and Inject options for keys, etc
    {
        public static JwtSecurityToken GetDecodedJwt(string jwt, TokenValidationParameters validationParameters = null, string securityKey = null)
        {
            var handler = new JwtSecurityTokenHandler();
            if (!handler.CanReadToken(jwt))
            {
                throw new HttpStatusCodeException(HttpStatusCode.Unauthorized, "Can't Read JSON Web Token!");
            }

            if (validationParameters == null)
            {
                if (!string.IsNullOrWhiteSpace(securityKey))
                {
                    validationParameters = GetRefreshTokenValidationParameters(securityKey);
                }
                else
                {
                    validationParameters = new TokenValidationParameters();
                }
            }

            handler.ValidateToken(jwt, validationParameters, out var token);
            return token as JwtSecurityToken;
        }

        private static TokenValidationParameters GetRefreshTokenValidationParameters(string securityKey)
        {
            return new TokenValidationParameters
            {
                IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(securityKey),
                ValidateIssuerSigningKey = true,
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = false
            };
        }

        public static TokenValidationParameters GetAccessTokenValidationParameters(string securityKey)
        {
            return new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = AuthOptions.Issuer,
                // ValidIssuer = _config["Security:Tokens:Issuer"],
                ValidateAudience = true,
                ValidAudience = AuthOptions.Audience,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(securityKey),
                ValidateLifetime = true,
            };
        }
    }
}
