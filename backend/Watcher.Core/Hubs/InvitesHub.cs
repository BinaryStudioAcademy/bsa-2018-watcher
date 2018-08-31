namespace Watcher.Core.Hubs
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.SignalR;

    using Watcher.Common.Helpers.Extensions;

    public class InvitesHub : Hub
    {
        public static readonly Dictionary<string, List<string>> UsersConnections = new Dictionary<string, List<string>>();

        public InvitesHub() {}

        public override async Task OnConnectedAsync()
        {
            if (Context.User.GetUserId() != null)
                AddUserConnection(Context.User.GetUserId(), Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.GetUserId() != null)
                RemoveUserConnection(Context.User.GetUserId(), Context.ConnectionId);
            await base.OnDisconnectedAsync(exception);
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
