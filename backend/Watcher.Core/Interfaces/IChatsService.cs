namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface IChatsService
    {
        Task<IEnumerable<ChatDto>> GetAllEntitiesAsync();

        Task<IEnumerable<ChatDto>> GetEntitiesByUserIdAsync(string id);

        Task<ChatDto> GetEntityByIdAsync(int id);

        Task<ChatDto> CreateEntityAsync(ChatRequest request);

        Task<bool> UpdateEntityByIdAsync(ChatUpdateRequest request, int id);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}
