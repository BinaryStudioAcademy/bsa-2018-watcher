namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public interface INotificationSettingsService
    {
        Task<IEnumerable<NotificationSettingDto>> GetEntitysByUserIdAsync(string userId);

        Task<bool> UpdateEntityByIdAsync(NotificationSettingRequest request, int id);

        Task<NotificationSetting> CreateEntityAsync(NotificationSettingRequest request, string userId);

    }
}
