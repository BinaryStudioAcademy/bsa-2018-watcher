namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Net;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;

    using Watcher.Common.Dtos;
    using Watcher.Common.Errors;
    using Watcher.Common.Helpers.Extensions;
    using Watcher.Common.Options;
    using Watcher.Common.Requests;
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


        public Task<TokenDto> CreateTokenAsync(ClaimsPrincipal user)
        {
            var uid = user.GetUserName();
            var email = user.GetUserEmail();

            var loginRequest = new UserLoginRequest(uid, email);

            return CreateTokenAsync(loginRequest);
        }

        public async Task<TokenDto> CreateTokenAsync(UserLoginRequest request)
        {
            // TODO: Parse token claim to get user email
            var userDto = await _usersService.GetEntityByIdAsync(request.Uid);

            // TODO: Add logic about registration purpose
            if (userDto == null)
            {
                throw new HttpStatusCodeException(HttpStatusCode.BadRequest, "User with such Uid not registered yet!");
            }

            return CreateTokenDto(userDto);
        }

        public TokenDto CreateTokenDto(UserDto user)
        {
            var claims = new List<Claim>
                             {
                                 new Claim(ClaimsIdentity.DefaultNameClaimType, user.Id),
                                 new Claim(ClaimTypes.Email, user.Email),
                                 new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name),
                             };

            var claimsIdentity = TokenUtil.CreateDefaultClaimsIdentity(claims);

            var tokenHandler = new JwtSecurityTokenHandler();
            var now = DateTime.UtcNow;

            var jwt = tokenHandler.CreateJwtSecurityToken(
                issuer: _tokenOptions.Value.Issuer,
                audience: _tokenOptions.Value.Audience,
                notBefore: now,
                subject: claimsIdentity,
                expires: now.AddYears(1), //now.Add(TimeSpan.FromMinutes(_tokenOptions.Value.Access_Token_Lifetime)),
                signingCredentials: new SigningCredentials(_tokenOptions.Value.GetSymmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
            ); // TODO: Get secret key from Configs

            var encodedJwt = tokenHandler.WriteToken(jwt);

            return new TokenDto(encodedJwt, user);
        }
    }
}
