namespace Watcher.Core.Hubs
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;
    
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

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
