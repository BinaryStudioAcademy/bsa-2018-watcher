namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface IUsersService
    {
        Task<IEnumerable<UserDto>> GetAllEntitiesAsync();

        Task<UserDto> GetEntityByIdAsync(string id);

        Task<UserDto> CreateEntityAsync(UserRegisterRequest request);

        Task<bool> UpdateEntityByIdAsync(UserUpdateRequest request, string id);

        Task<bool> DeleteEntityByIdAsync(string id);

        Task<UserDto> CreateEntityAsync(ClaimsPrincipal request);
    }
}