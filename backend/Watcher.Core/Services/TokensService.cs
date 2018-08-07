namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.IdentityModel.Tokens;

    using Watcher.Common.Dtos;
    using Watcher.Core.Auth;
    using Watcher.Core.Interfaces;

    public class TokensService : ITokensService
    {
        private readonly IUsersService _usersService;

        public TokensService(IUsersService usersService) // TODO Inject options here
        {
            _usersService = usersService;
        }

        public async Task<TokenDto> CreateTokenAsync(ClaimsPrincipal principal)
        {
            // TODO: Parse token claim to get user email
            var userDto = await _usersService.GetEntityByIdAsync("Some email"); // email (from token )

            return GenerateToken(userDto);
        }

        public TokenDto GenerateToken(UserDto user)
        {
            var claims = new List<Claim>
                             {
                                 new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                                 new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.Name)
                             };

            var claimsIdentity = CreateDefaultClaimsIdentity(claims);

            var tokenHandler = new JwtSecurityTokenHandler();

            const string sec = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1";

            var now = DateTime.UtcNow;

            var jwt = tokenHandler.CreateJwtSecurityToken(
                issuer: AuthOptions.Issuer,
                audience: AuthOptions.Audience,
                notBefore: now,
                subject: claimsIdentity,
                expires: now.Add(TimeSpan.FromMinutes(AuthOptions.Access_token_Lifetime)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(sec), SecurityAlgorithms.HmacSha256Signature)
                ); // TODO: Get secret key from Configs

            var encodedJwt = tokenHandler.WriteToken(jwt);

            return new TokenDto(encodedJwt);
        }

        public static ClaimsIdentity CreateDefaultClaimsIdentity(IEnumerable<Claim> claims)
        {
            return new ClaimsIdentity(claims,
                                      "Token",
                                      ClaimsIdentity.DefaultNameClaimType,
                                      ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
