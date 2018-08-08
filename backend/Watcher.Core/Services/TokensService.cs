namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;

    using Watcher.Common.Dtos;
    using Watcher.Common.Options;
    using Watcher.Core.Auth;
    using Watcher.Core.Interfaces;

    public class TokensService : ITokensService
    {
        private readonly IUsersService _usersService;
        private readonly IOptions<WatcherTokenOptions> _tokenOptions;


        public TokensService(IUsersService usersService, IOptions<WatcherTokenOptions> tokenOptions) // TODO Inject options here
        {
            _usersService = usersService;
            _tokenOptions = tokenOptions;
        }

        public async Task<TokenDto> CreateTokenAsync(ClaimsPrincipal principal)
        {
            // TODO: Parse token claim to get user email
            var userDto = await _usersService.GetEntityByIdAsync("Some email"); // email (from token )

            return CreateFakeTokenDto(userDto);
        }

        public TokenDto CreateTokenDto(UserDto user)
        {
            var claims = new List<Claim>
                             {
                                 new Claim(ClaimsIdentity.DefaultNameClaimType, "rostik@gmail.com"), // user.Email
                                 new Claim(ClaimsIdentity.DefaultRoleClaimType, "Admin") // user.Role.Name
                             };

            var claimsIdentity = TokenUtil.CreateDefaultClaimsIdentity(claims);

            var tokenHandler = new JwtSecurityTokenHandler();
            var now = DateTime.UtcNow;

            var jwt = tokenHandler.CreateJwtSecurityToken(
                issuer: _tokenOptions.Value.Issuer,
                audience: _tokenOptions.Value.Audience,
                notBefore: now,
                subject: claimsIdentity,
                expires: now.Add(TimeSpan.FromMinutes(_tokenOptions.Value.Access_Token_Lifetime)),
                signingCredentials: new SigningCredentials(_tokenOptions.Value.GetSymmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
            ); // TODO: Get secret key from Configs

            var encodedJwt = tokenHandler.WriteToken(jwt);

            return new TokenDto(encodedJwt);
        }

        public TokenDto CreateFakeTokenDto(UserDto user)
        {
            var claims = new List<Claim>
                             {
                                 new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                                 new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.Name)
                             };

            var claimsIdentity = TokenUtil.CreateDefaultClaimsIdentity(claims);

            var tokenHandler = new JwtSecurityTokenHandler();
            var now = DateTime.UtcNow;

            var jwt = tokenHandler.CreateJwtSecurityToken(
                issuer: _tokenOptions.Value.Issuer,
                audience: _tokenOptions.Value.Audience,
                notBefore: now,
                subject: claimsIdentity,
                expires: now.Add(TimeSpan.FromMinutes(_tokenOptions.Value.Access_Token_Lifetime)),
                signingCredentials: new SigningCredentials(_tokenOptions.Value.GetSymmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
                ); // TODO: Get secret key from Configs

            var encodedJwt = tokenHandler.WriteToken(jwt);

            return new TokenDto(encodedJwt, user);
        }
    }
}
