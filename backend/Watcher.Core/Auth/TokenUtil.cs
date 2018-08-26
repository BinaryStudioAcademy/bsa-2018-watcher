namespace Watcher.Core.Auth
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;

    using Microsoft.Extensions.Logging;
    using Microsoft.IdentityModel.Tokens;

    using Serilog;
    using Serilog.Context;

    public class TokenUtil
    {
        public static JwtSecurityToken GetDecodedJwt(string jwt, TokenValidationParameters validationParameters)
        {
            var handler = new JwtSecurityTokenHandler();
            if (!handler.CanReadToken(jwt))
            {
                return null;
            }

            try
            {
                handler.ValidateToken(jwt, validationParameters, out var token);
                return token as JwtSecurityToken;
            }
            catch (Exception e)
            {
                var eventId = new EventId(403);
                using (LogContext.PushProperty("LogEventId", eventId.Id))
                using (LogContext.PushProperty("ClassName", nameof(TokenUtil)))
                using (LogContext.PushProperty("Source", e.Source))
                {
                    Log.Error(e, $"Watcher Token was not validated: {e.Message}");
                }

                return null;
            }
        }

        public static ClaimsIdentity CreateDefaultClaimsIdentity(IEnumerable<Claim> claims)
        {
            return new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
