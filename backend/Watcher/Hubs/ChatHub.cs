using System.Security.Claims;
using Microsoft.Extensions.Logging;
using Serilog.Context;
using Watcher.Core.Providers;

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
        private readonly ILogger<ChatHub> _logger;

        private static readonly Dictionary<string, List<string>> UsersConnections = new Dictionary<string, List<string>>();

        public ChatHub(ILoggerFactory loggerFactory,
                        IChatsService chatsService, 
                        IMessagesService messagesService, 
                        IOrganizationService organizationService, 
                        INotificationService notificationService)
        {
            _logger = loggerFactory?.CreateLogger<ChatHub>() ?? throw new ArgumentNullException(nameof(loggerFactory));
            _chatsService = chatsService;
            _messagesService = messagesService;
        }

        public async Task Send(MessageRequest messageRequest)
        {
            var message = await _messagesService.CreateEntityAsync(messageRequest);
            if (message == null) return;

            var createdMessage = await _messagesService.GetEntityByIdAsync(message.Id);
            var usersInChat = await _chatsService.GetUsersByChatIdAsync(createdMessage.ChatId);

            foreach (var userDto in usersInChat)
            {
                if (!UsersConnections.ContainsKey(userDto.Id)) continue;
                foreach (string connectionId in UsersConnections[userDto.Id])
                    await Clients.Client(connectionId).SendAsync("ReceiveMessage", createdMessage);
            }
        }

        public async Task MarkMessageAsRead(int messageId)
        {
            var result = await _messagesService.UpdateEntityByIdAsync(new MessageUpdateRequest { WasRead = true }, messageId);
            if (!result) return;
        }

        public async Task InitializeChat(ChatRequest chatRequest)
        {
            var createdChat = await _chatsService.CreateEntityAsync(chatRequest);
            if (createdChat == null) return;

            var chat = await _chatsService.GetEntityByIdAsync(createdChat.Id);

            foreach (var user in chat.Users)
            {
                if (!UsersConnections.ContainsKey(user.Id)) continue;
                foreach (string connectionId in UsersConnections[user.Id])
                    await Clients.Client(connectionId).SendAsync("ChatCreated", chat);
            }
        }

        public async Task UpdateChat(ChatUpdateRequest chat, int chatId)
        {
            var result = await _chatsService.UpdateEntityByIdAsync(chat, chatId);
            if (!result) return;

            var changedChat = await _chatsService.GetEntityByIdAsync(chatId);

            foreach (var user in changedChat.Users)
            {
                if (!UsersConnections.ContainsKey(user.Id)) continue;
                foreach (string connectionId in UsersConnections[user.Id])
                    await Clients.Client(connectionId).SendAsync("ChatChanged", changedChat);
            }
        }

        public async Task AddUserToChat(int chatId, string userId)
        {
            var result = await _chatsService.AddUserToChat(chatId, userId);
            if (!result) return;

            var changedChat = await _chatsService.GetEntityByIdAsync(chatId);

            foreach (var user in changedChat.Users)
            {
                if (!UsersConnections.ContainsKey(user.Id)) continue;
                foreach (string connectionId in UsersConnections[user.Id])
                    await Clients.Client(connectionId).SendAsync("ChatChanged", changedChat);
            }
        }

        public async Task DeleteUserFromChat(int chatId, string userId)
        {
            var result = await _chatsService.DeleteUserFromChat(chatId, userId);
            if (!result) return;

            var changedChat = await _chatsService.GetEntityByIdAsync(chatId);

            foreach (var user in changedChat.Users)
            {
                if (!UsersConnections.ContainsKey(user.Id)) continue;
                foreach (string connectionId in UsersConnections[user.Id])
                    await Clients.Client(connectionId).SendAsync("ChatChanged", changedChat);
            }
        }

        public override async Task OnConnectedAsync()
        {
            using (LogContext.PushProperty("ClassName", this.GetType().FullName))
            using (LogContext.PushProperty("Source", this.GetType().Name))
            {
                foreach (var claim in Context.User.Claims)
                {
                    _logger.LogError($"Claims {claim.Type}, {claim.Value}");
                }
            }
            AddUserConnection(Context.User.FindFirstValue("unique_name"), Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            RemoveUserConnection(Context.User.FindFirstValue("unique_name"), Context.ConnectionId);
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
