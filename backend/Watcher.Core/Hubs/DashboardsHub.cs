namespace Watcher.Core.Hubs
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Core.Interfaces;

    public class DashboardsHub : Hub
    {
        private readonly IServiceBusProvider _serviceBusProvider;

        public DashboardsHub(IServiceBusProvider serviceBusProvider)
        {
            _serviceBusProvider = serviceBusProvider;
        }

        /// <summary>
        /// Called when a new connection is established with the hub.
        /// </summary>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous connect.</returns>
        public override Task OnConnectedAsync()
        {
            Groups.AddToGroupAsync(Context.ConnectionId, "Market Data Feed");
            Clients.All.SendAsync("BroadcastMessage", Context.ConnectionId + "Connected");
            return base.OnConnectedAsync();
        }

        /// <summary>
        /// Called when a new connection with the hub is interrupted.
        /// </summary>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Threading.Tasks.Task"/> that represents the asynchronous disconnect.
        /// </returns>
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("BroadcastMessage", $"Connection: {Context.ConnectionId} disconnected {exception?.Message}");
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, "Market Data Feed");
            await base.OnDisconnectedAsync(exception ?? new Exception("Something went wrong"));
        }

        [Authorize]
        public async Task SubscribeToInstanceById(Guid GuidId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, GuidId.ToString());

            await _serviceBusProvider.SendMessageToServiceBus(GuidId.ToString());
        }

        [Authorize]
        public Task UnSubscribeFromInstanceById(Guid GuidId)
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, GuidId.ToString());
        }

        [Authorize(Roles = "User")]
        public void Send(string userId, string message)
        {
            // We don't have authorization yet so message wont be sent to anyone
            var senderCurrentUserId = Context.User.FindFirstValue("unique_name");
            Clients.User(userId).SendAsync("BroadcastMessage", $"User with Id {senderCurrentUserId} sent you message: {message}");
        }
    }
}
