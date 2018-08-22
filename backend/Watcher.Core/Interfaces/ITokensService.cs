namespace Watcher.Core.Interfaces
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface ITokensService
    {
        Task<TokenDto> CreateTokenAsync(UserLoginRequest request);

        TokenDto CreateTokenDto(UserDto user);
        Task<TokenDto> CreateTokenAsync(ClaimsPrincipal user);
    }
}