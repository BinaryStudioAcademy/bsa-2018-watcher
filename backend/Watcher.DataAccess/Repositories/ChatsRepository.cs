﻿using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Watcher.DataAccess.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using Microsoft.EntityFrameworkCore;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class ChatsRepository : Repository<Chat, int>, IChatsRepository
    {
        public ChatsRepository(WatcherDbContext context, IMapper automapper) : base(context, automapper)
        {
        }

        public async Task<List<Chat>> GetChatsByUserId(string id)
        {
            IQueryable<Chat> chats = Context.UserChat
                .Where(uc => uc.UserId == id)
                .Select(uc => uc.Chat)
                .Include(uc => uc.UserChats)
                    .ThenInclude(uc => uc.User);

            return await chats.ToListAsync();
        }

        public async Task<List<User>> GetUsersByChatId(int id)
        {
            IQueryable<User> users = Context.UserChat.Where(uc => uc.ChatId == id).Select(uc => uc.User);

            return await users.ToListAsync();
        }

        public async Task<UserChat> AddUserChat(UserChat userChat)
        {
             EntityEntry<UserChat> entityEntry = await Context.UserChat.AddAsync(userChat);

            return entityEntry.Entity;
        }

        public async Task DeleteUserChat(UserChat userChat)
        {
            if (Context.Entry(userChat).State == EntityState.Detached)
            {
                Context.UserChat.Attach(userChat);
            }

            Context.UserChat.Remove(userChat);
        }
    }
}
