namespace Watcher.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Watcher.Core.Interfaces;

    [Route("api/[controller]")]
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
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tokenResponse = await _tokensService.CreateTokenAsync(User);
            if (tokenResponse != null)
            {
                return Ok(tokenResponse);
            }

            return BadRequest();
        }

        [Authorize] // Authorize Validate only Firebase token
        [HttpGet("Register")]
        public async Task<IActionResult> Register()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userDto = await _usersService.CreateEntityAsync(User);
            var token = _tokensService.GenerateToken(userDto);
            if (token == null)
            {
                return BadRequest("User with such email already exists");
            }

            return Ok(token);
        }
    }
}
