using System.Collections.Generic;
using Watcher.Common.Dtos;
using Watcher.Common.Enums;

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
        private readonly IOrganizationService _organizationService;

        private static Dictionary<string, List<string>> userConnections = new Dictionary<string, List<string>>();

        public ChatHub(IChatsService chatsService, IMessagesService messagesService, IOrganizationService organizationService)
        {
            _chatsService = chatsService;
            _messagesService = messagesService;
            _organizationService = organizationService;
        }

        public async Task Send(MessageRequest messageRequest)
        {
            var message = await _messagesService.CreateEntityAsync(messageRequest);
            if (message == null) return;

            var createdMessage = await _messagesService.GetEntityByIdAsync(message.Id);
            var usersInChat = await _chatsService.GetUsersByChatIdAsync(createdMessage.ChatId);

            foreach (var userDto in usersInChat)
            {
                //if(userDto.Id != createdMessage.User.Id)
                {
                   Clients.User(userDto.Id).SendAsync("ReceiveMessage", createdMessage);
                }
            }
        }

        public async Task InitializeChat(ChatRequest chatRequest)
        {
            var createdChat = await _chatsService.CreateEntityAsync(chatRequest);
            if (createdChat == null) return;

            var usersInChat = await _chatsService.GetUsersByChatIdAsync(createdChat.Id);
            
            if (createdChat.Type == ChatType.BetweenUsers)
            {
                foreach (var user in usersInChat)
                {
                    await Clients.User(user.Id).SendAsync("ChatCreated", createdChat);
                }
            }
            else if (createdChat.Type == ChatType.InOrganization)
            {
                // TODO: Create chat for organization if haven`t created yet.
            }
        }

        public async Task AddUserToChat(int chatId, string userid)
        {
            var users = await _chatsService.GetUsersByChatIdAsync(chatId);

            var userDto = await _chatsService.AddUserToChat(chatId, userid);

            if (userDto == null) return;

            foreach (var user in users)
            {
                await Clients.User(userDto.Id).SendAsync("UserAdded");
            }
        }

        public override async Task OnConnectedAsync()
        {
            //await Clients.All.SendAsync("BroadcastMessage", Context.ConnectionId + "Connected");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            //await Clients.All.SendAsync("BroadcastMessage", $"Connection: {Context.ConnectionId} disconnected {exception?.Message}");
            await base.OnDisconnectedAsync(exception);
        }
    }
}
