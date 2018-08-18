namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface IMessagesService
    {
        Task<IEnumerable<MessageDto>> GetAllEntitiesAsync();

        Task<IEnumerable<MessageDto>> GetEntitiesByChatIdAsync(int id);

        Task<MessageDto> GetEntityByIdAsync(int id);

        Task<MessageDto> CreateEntityAsync(MessageRequest request);

        Task<bool> UpdateEntityByIdAsync(MessageUpdateRequest request, int id);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}
