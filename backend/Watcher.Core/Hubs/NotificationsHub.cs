﻿namespace Watcher.Core.Hubs
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;


    using Microsoft.AspNetCore.SignalR;
    using Microsoft.AspNetCore.Authorization;

    using Watcher.Common.Dtos;
    using Watcher.Common.Helpers.Extensions;

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

        [Authorize]
        public async Task DeleteNotification(NotificationDto notificationDto)
        {
            await Clients.User(notificationDto.UserId).SendAsync("DeleteNotification", notificationDto.Id);
        }

        public override Task OnConnectedAsync()
        {
            if (Context.User.GetUserId() != null)
                AddUserConnection(Context.User.GetUserId(), Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.GetUserId() != null)
                RemoveUserConnection(Context.User.GetUserId(), Context.ConnectionId);
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
