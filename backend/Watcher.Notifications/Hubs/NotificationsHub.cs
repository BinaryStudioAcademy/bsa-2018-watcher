namespace Watcher.Notifications.Hubs
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.SignalR;

    public class NotificationsHub : Hub
    {
        public NotificationsHub()
        {
            
        }

        /// <summary>
        /// Called when a new connection is established with the hub.
        /// </summary>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous connect.</returns>
        public override Task OnConnectedAsync()
        {
            Clients.All.SendAsync("BroadcastMessage", Context.ConnectionId + "Connected");
            return base.OnConnectedAsync();
        }

        public void BroadcastMessage(string message)
        {
            Clients.All.SendAsync("BroadcastMessage", message);
        }

        public void Echo()
        {
            Clients.Client(Context.ConnectionId).SendAsync("echo", " (echo from server)");
        }

        public Task Send(string item)
        {
            return Clients.Group(item).SendAsync("Send", item + " From Hub");
        }

        public async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("JoinGroup", groupName);
            
            await Clients.Client(Context.ConnectionId).SendAsync("History", $"You joined the group: {groupName}");
        }

        public async Task LeaveGroup(string groupName)
        {
            await Clients.Group(groupName).SendAsync("LeaveGroup", groupName);
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }
    }
}
