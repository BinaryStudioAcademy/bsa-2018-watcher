namespace Watcher.Core.Hubs
{
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Common.Dtos;

    public class NotificationsHub : Hub
    {
        public static readonly Dictionary<string, List<string>> UsersConnections = new Dictionary<string, List<string>>();

        public NotificationsHub()
        {
        }

        public async Task SendNotification(NotificationDto notificationDto)
        {
            await Clients.User(notificationDto.UserId).SendAsync("AddNotification", notificationDto);
        }

        public override Task OnConnectedAsync()
        {
            if (Context.User.FindFirstValue("unique_name") != null)
                AddUserConnection(Context.User.FindFirstValue("unique_name"), Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            // Build fail
            if (Context.User.FindFirstValue("unique_name") != null)
                RemoveUserConnection(Context.User.FindFirstValue("unique_name"), Context.ConnectionId);
            return base.OnDisconnectedAsync(exception ?? new Exception("Something went wrong"));
        }

        public void AddUserConnection(string userId, string connectionId)
        {
            if (UsersConnections.ContainsKey(userId))
                UsersConnections[userId].Add(connectionId);
            else
            {
                UsersConnections.Add(userId, new List<string> { connectionId });
            }
        }

        public bool RemoveUserConnection(string userId, string connectionId)
        {
            return UsersConnections.ContainsKey(userId) && UsersConnections[userId].Remove(connectionId);
        }
    }
}
