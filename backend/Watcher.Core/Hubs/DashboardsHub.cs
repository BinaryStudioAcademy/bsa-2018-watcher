namespace Watcher.Core.Hubs
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Extensions.Logging;

    using Serilog.Context;

    using Watcher.Common.Helpers.Extensions;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;

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
            var name = Context.User.FindFirstValue("unique_name");
            Debug.WriteLine($"*****************{name}****************");
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
            var name = Context.User.FindFirstValue("unique_name");
            Debug.WriteLine($"*****************{name}****************");
            using (LogContext.PushProperty("ClassName", this.GetType().FullName))
            using (LogContext.PushProperty("Source", exception?.Source))
            {
                _logger.LogError($"Connection: {Context.ConnectionId} disconnected {exception?.Message}");
            }

            return base.OnDisconnectedAsync(exception ?? new Exception("Something went wrong"));
        }

        [Authorize]
        public Task GetClaims()
        {
            var id = Context.User.GetUserId();
            var mail = Context.User.GetUserEmail();
            var role = Context.User.GetUserRole();
            var IdUserRole = Context.User.IsInRole("User");
            var IsAdminRole = Context.User.IsInRole("Admin");

            var claims = Context.User.Claims.Select(u => new { u.Type, u.Value });
            return Clients.Client(Context.ConnectionId).SendAsync("UserClaimsData", claims);
        }

        [Authorize]
        public Task SubscribeToInstanceById(Guid GuidId)
        {
            var name = Context.User.FindFirstValue("unique_name");
            Debug.WriteLine($"*****************{name}****************");
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
