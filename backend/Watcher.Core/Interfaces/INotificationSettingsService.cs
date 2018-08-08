namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface INotificationSettingsService
    {
        Task<IEnumerable<NotificationSettingDto>> GetEntitysByUserIdAsync(int userId);

        Task<bool> UpdateEntityByIdAsync(NotificationSettingRequest request, int id);
    }
}
