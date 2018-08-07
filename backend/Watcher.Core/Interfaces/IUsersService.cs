namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface IUsersService
    {
        Task<IEnumerable<UserDto>> GetAllEntitiesAsync();

        Task<UserDto> GetEntityByIdAsync(int id);

        Task<UserDto> CreateEntityAsync(UserRegisterRequest request);

        Task<bool> UpdateEntityByIdAsync(UserUpdateRequest request, int id);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}