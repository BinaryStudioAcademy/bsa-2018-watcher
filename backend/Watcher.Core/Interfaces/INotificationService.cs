namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Common.Enums;

    public interface INotificationService
    {
        Task<IEnumerable<NotificationDto>> GetAllEntitiesAsync();

        Task<IEnumerable<NotificationDto>> GetEntitiesByUserIdAsync(string userId);

        Task<NotificationDto> GetEntityByIdAsync(int id);

        Task<IEnumerable<NotificationDto>> CreateEntityAsync(NotificationRequest notificationRequest);

        Task<IEnumerable<NotificationDto>> CreateEntityForAllAsync(NotificationRequest notificationRequest);

        Task<bool> UpdateEntityByIdAsync(NotificationUpdateRequest request, int id);

        Task<bool> UpdateEntitiesAsync(IEnumerable<NotificationUpdateRequest> requests);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}
