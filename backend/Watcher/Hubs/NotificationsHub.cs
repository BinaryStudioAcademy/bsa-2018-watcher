﻿namespace Watcher.Hubs
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    public class NotificationsHub : Hub
    {
        /// <summary>
        /// The Samples Service.
        /// </summary>
        private readonly ISamplesService _samplesService;

        public NotificationsHub(ISamplesService samplesService)
        {
            _samplesService = samplesService;
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
            Clients.All.SendAsync("BroadcastMessage", $"Connection: {Context.ConnectionId} disconnected {exception?.Message}");
            return base.OnConnectedAsync();
        }

        /// <summary>
        /// Send Message to all connected clients
        /// </summary>
        /// <param name="message"></param>
        public void BroadcastMessage(string message)
        {
            Clients.All.SendAsync("BroadcastMessage", message);
        }


        /// <summary>
        /// Send message to caller of this method(to connection that invoked this method)
        /// </summary>
        [Authorize]
        public void Echo()
        {
            Clients.Client(Context.ConnectionId).SendAsync("Echo", " (echo from server)");
        }

        /// <summary>
        /// Creates sample, Invokes callers method: AddSample with
        /// arguments: SampleDto, string, number
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Task</returns>
        [Authorize(Roles = "Admin")]
        public async Task CreateSample(SampleRequest request)
        {
            // TODO: validate model using Fluent Validator
            var dto = await _samplesService.CreateEntityAsync(request);
            await Clients.Client(Context.ConnectionId).SendAsync("AddSample", dto, "Second Parameter", 3);
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
