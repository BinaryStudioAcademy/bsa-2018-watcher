namespace Watcher.Core.Hubs
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Extensions.Logging;

    using Watcher.Core.Interfaces;

    public class DashboardsHub : Hub
    {
        private readonly IServiceBusProvider _serviceBusProvider;
        private readonly ILogger<DashboardsHub> _logger;

        public DashboardsHub(IServiceBusProvider serviceBusProvider,
                             ILogger<DashboardsHub> logger)
        {
            _serviceBusProvider = serviceBusProvider;
            _logger = logger;
        }

        /// <summary>
        /// Called when a new connection is established with the hub.
        /// </summary>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous connect.</returns>
        public override Task OnConnectedAsync()
        {
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
        public override Task OnDisconnectedAsync(Exception exception)
        {
            _logger.LogError($"Connection: {Context.ConnectionId} disconnected {exception?.Message}");
            return base.OnDisconnectedAsync(exception ?? new Exception("Something went wrong"));
        }

        [Authorize]
        public Task SubscribeToInstanceById(Guid GuidId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GuidId.ToString());
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
