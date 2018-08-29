using System.Collections.Generic;
using System.Threading.Tasks;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;

namespace Watcher.Core.Interfaces
{
    public interface IFeedbackService
    {
        Task<IEnumerable<FeedbackDto>> GetAllEntitiesAsync();

        Task<IEnumerable<FeedbackDto>> GetRangeOfEntitiesAsync(int page, int pageSize);

        Task<int> GetNumberOfEntitiesAsync();

        Task<FeedbackDto> GetEntityByIdAsync(int id);

        Task<FeedbackDto> CreateEntityAsync(FeedbackRequest request);

        Task<bool> UpdateEntityByIdAsync(FeedbackDto request, int id);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}
