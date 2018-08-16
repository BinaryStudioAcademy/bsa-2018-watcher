using System.Collections.Generic;
using Watcher.Common.Dtos;

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

        [Authorize()]
        public async Task Send(string userId, MessageRequest messageRequest)
        {
            MessageDto message = await _messagesService.CreateEntityAsync(messageRequest);

            IEnumerable<UserDto> users = await _chatsService.GetUsersByChatIdAsync(messageRequest.Chat.Id);

            // foreach (var userDto in users)
            Clients.User(userId).SendAsync("ReceiveMessage", message.Text);
        }

        public async Task InitializeChat(ChatRequest chatRequest, string userId)
        {
            ChatDto chatDto = await _chatsService.CreateEntityAsync(chatRequest);

            if (chatRequest.CreatedBy.Id != userId)
                await _chatsService.AddUserToChat(chatDto.Id, userId);

            await Clients.User(chatDto.CreatedBy.Id).SendAsync("ChatCreated", chatDto.Id);
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
