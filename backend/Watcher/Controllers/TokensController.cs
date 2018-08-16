﻿namespace Watcher.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.Utils;

    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        private readonly ITokensService _tokensService;
        private readonly IUsersService _usersService;

        public TokensController(ITokensService tokensService, IUsersService usersService)
        {
            _tokensService = tokensService;
            _usersService = usersService;
        }

        [Authorize]
        [HttpGet("User")]
        public async Task<IActionResult> GetUserByTokens()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tokenResponse = await _tokensService.CreateTokenAsync(User);
            if (tokenResponse == null)
            {
                return BadRequest("User with such Uid not registered yet!");
            }

            return Ok(tokenResponse);
        }

        [Authorize]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest request)
        {
            // return BadRequest("User with such Uid not registered yet!");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tokenResponse = await _tokensService.CreateTokenAsync(request);
            if (tokenResponse == null)
            {
                return BadRequest("User with such Uid not registered yet!");
            }

            return Ok(tokenResponse);
        }

        [Authorize] // Authorize Validate only Firebase token
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userDto = await _usersService.CreateEntityAsync(request);
            var token = _tokensService.CreateTokenDto(userDto);
            if (token == null)
            {
                return StatusCode(500, "Internal Servcer Error");
            }

            return Ok(token);
        }
    }
}
