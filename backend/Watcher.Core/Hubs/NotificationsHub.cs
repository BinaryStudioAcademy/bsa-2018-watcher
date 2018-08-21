namespace Watcher.Core.Hubs
{
    using System.Threading.Tasks;
    
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Common.Dtos;

    public class NotificationsHub : Hub
    {
        public NotificationsHub()
        {
        }

        public async Task SendNotification(NotificationDto notificationDto)
        {
            await Clients.User(notificationDto.UserId).SendAsync("AddNotification", notificationDto);
        }
    }
}
