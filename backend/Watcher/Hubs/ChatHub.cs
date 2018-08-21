namespace Watcher.Hubs
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    public class ChatHub : Hub
    {
        private readonly IChatsService _chatsService;
        private readonly IMessagesService _messagesService;
        private readonly IOrganizationService _organizationService;
        private readonly INotificationService _notificationService;


        private static Dictionary<string, List<string>> userConnections = new Dictionary<string, List<string>>();

        public ChatHub(IChatsService chatsService, 
                        IMessagesService messagesService, 
                        IOrganizationService organizationService, 
                        INotificationService notificationService)
        {
            _chatsService = chatsService;
            _messagesService = messagesService;
            _organizationService = organizationService;
            _notificationService = notificationService;
        }

        public async Task Send(MessageRequest messageRequest)
        {
            var message = await _messagesService.CreateEntityAsync(messageRequest);
            if (message == null) return;

            var createdMessage = await _messagesService.GetEntityByIdAsync(message.Id);
            var usersInChat = await _chatsService.GetUsersByChatIdAsync(createdMessage.ChatId);

            foreach (var userDto in usersInChat)
            {
                await Clients.User(userDto.Id).SendAsync("ReceiveMessage", createdMessage);
            }
        }

        public async Task InitializeChat(ChatRequest chatRequest)
        {
            var createdChat = await _chatsService.CreateEntityAsync(chatRequest);
            if (createdChat == null) return;

            var usersInChat = await _chatsService.GetUsersByChatIdAsync(createdChat.Id);

            foreach (var user in usersInChat)
            {
                await Clients.User(user.Id).SendAsync("ChatCreated", createdChat);
            }
        }

        public async Task UpdateChat(ChatUpdateRequest chat, int chatId)
        {
            var result = await _chatsService.UpdateEntityByIdAsync(chat, chatId);
            if (!result) return;

            var changedChat = await _chatsService.GetLightEntityByIdAsync(chatId);
            var usersInChat = await _chatsService.GetUsersByChatIdAsync(chatId);

            foreach (var user in usersInChat)
            {
                await Clients.User(user.Id).SendAsync("ChatChanged", changedChat);
            }
        }

        public async Task AddUserToChat(int chatId, string userId)
        {
            var result = await _chatsService.AddUserToChat(chatId, userId);
            if (!result) return;

            var usersInChat = await _chatsService.GetUsersByChatIdAsync(chatId);

            foreach (var user in usersInChat)
            {
                await Clients.User(user.Id).SendAsync("UserAdded");
            }
        }

        public async Task DeleteUserFromChat(int chatId, string userId)
        {
            var result = await _chatsService.DeleteUserFromChat(chatId, userId);
            if (!result) return;

            var usersInChat = await _chatsService.GetUsersByChatIdAsync(chatId);

            foreach (var user in usersInChat)
            {
                await Clients.User(user.Id).SendAsync("UserDeleted");
            }
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await base.OnDisconnectedAsync(exception);
        }
    }
}
