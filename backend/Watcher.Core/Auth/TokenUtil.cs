namespace Watcher.Core.Auth
{
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Net;
    using System.Security.Claims;

    using Microsoft.IdentityModel.Tokens;

    using Watcher.Common.Errors;

    public class TokenUtil
    {
        public static JwtSecurityToken GetDecodedJwt(string jwt, TokenValidationParameters validationParameters)
        {
            var handler = new JwtSecurityTokenHandler();
            if (!handler.CanReadToken(jwt))
            {
                throw new HttpStatusCodeException(HttpStatusCode.Unauthorized, "Can't Read JSON Web Token!");
            }

            handler.ValidateToken(jwt, validationParameters, out var token);
            return token as JwtSecurityToken;
        }

        public static ClaimsIdentity CreateDefaultClaimsIdentity(IEnumerable<Claim> claims)
        {
            return new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
