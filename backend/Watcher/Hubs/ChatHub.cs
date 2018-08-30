using Watcher.Common.Dtos;

namespace Watcher.Hubs
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.SignalR;
    using Microsoft.AspNetCore.Authorization;

    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.Common.Helpers.Extensions;

    public class ChatHub : Hub
    {
        private readonly IChatsService _chatsService;
        private readonly IMessagesService _messagesService;
        private readonly IEmailProvider _emailProvider;

        private static readonly Dictionary<string, List<string>> UsersConnections = new Dictionary<string, List<string>>();

        public ChatHub(
            IChatsService chatsService,
            IMessagesService messagesService,
            IEmailProvider emailProvider)
        {
            _emailProvider = emailProvider;
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

                // Sending to email
                SendToEmailIfNeeded(userDto, createdMessage);
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

        public async Task DeleteChat(int id)
        {
            var deleteChat = await _chatsService.GetEntityByIdAsync(id);

            var result = await _chatsService.DeleteEntityByIdAsync(id);
            if (result)
            {
                foreach (var user in deleteChat.Users)
                {
                    if (!UsersConnections.ContainsKey(user.Id)) continue;
                    foreach (string connectionId in UsersConnections[user.Id])
                        await Clients.Client(connectionId).SendAsync("ChatDeleted", deleteChat);
                }
            }
        }

        public override async Task OnConnectedAsync()
        {
            if (Context.User.GetUserId() != null)
                AddUserConnection(Context.User.GetUserId(), Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.GetUserId() != null)
                RemoveUserConnection(Context.User.GetUserId(), Context.ConnectionId);
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

        private async Task SendToEmailIfNeeded(UserDto userDto, MessageDto messageDto)
        {
            if (userDto.Id != messageDto.User.Id)
            {
                var settings = await _chatsService.GetSettingsForUserIdAsync(userDto.Id, messageDto.ChatId);
                if (settings != null && settings.IsEmailable)
                {
                    await _emailProvider.SendMessageOneToOne("watcher@net.com",
                        $"Chat message from {messageDto.User.DisplayName}", userDto.Email,
                        messageDto.Text, "");
                }
            }
        }
    }
}
