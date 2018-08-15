using System.Collections.Generic;

namespace Watcher.Hubs
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    public class ChatHub : Hub
    {
        private readonly IChatsService _chatsService;
        private readonly IMessagesService _messagesService;

        private static Dictionary<string, List<string>> userConnections = new Dictionary<string, List<string>>();

        public ChatHub(IChatsService chatsService, IMessagesService messagesService)
        {
            _chatsService = chatsService;
            _messagesService = messagesService;
        }

        public void Send(string userId, string message)
        {
            if (userConnections[userId] == null)
                return;

            foreach (string connectionId in userConnections[userId])
                Clients.Client(connectionId).SendAsync("ReceiveMessage", message);
        }

        public async Task InitializeChat(ChatRequest chatRequest)
        {
            await _chatsService.CreateEntityAsync(chatRequest);
        }

        public void AddUser(string userId)
        {
            if (!userConnections.ContainsKey(userId))
                userConnections.Add(userId, new List<string> { Context.ConnectionId });
            else
                userConnections[userId].Add(Context.ConnectionId);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("BroadcastMessage", Context.ConnectionId + "Connected");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("BroadcastMessage", $"Connection: {Context.ConnectionId} disconnected {exception?.Message}");
            await base.OnDisconnectedAsync(exception);
        }
    }
}
