namespace Watcher.Core.Auth
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Net;

    using Microsoft.IdentityModel.Tokens;

    using Watcher.Common.Errors;

    public class TokenUtil
    {
        public static JwtSecurityToken GetDecodedJwt(string jwt, string securityKey, TokenValidationParameters validationParameters = null)
        {
            var handler = new JwtSecurityTokenHandler();
            if (!handler.CanReadToken(jwt))
            {
                throw new HttpStatusCodeException(HttpStatusCode.Unauthorized, "Can't Read JSON Web Token!");
            }

            validationParameters = validationParameters ?? GetRefreshTokenValidationParameters(securityKey);
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
    }
}
