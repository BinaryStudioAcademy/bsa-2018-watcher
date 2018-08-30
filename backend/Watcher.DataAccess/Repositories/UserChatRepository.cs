namespace Watcher.DataAccess.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Query;

    using Watcher.Common.Interfaces.Entities;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class UserChatRepository : IUserChatRepository
    {
        protected readonly WatcherDbContext _context;
        protected readonly DbSet<UserChat> _dbSet;
        protected readonly IMapper _mapper;

        public UserChatRepository(WatcherDbContext context, IMapper automapper)
        {
            _context = context;
            _dbSet = _context.Set<UserChat>();
            _mapper = automapper;
        }
        public async Task<UserChat> CreateAsync(UserChat entity)
        {
            await _dbSet.AddAsync(entity);

            return entity;
        }
        public async Task<List<Chat>> GetChatsByUserId(string id)
        {
            IQueryable<Chat> chats = _context.UserChat.AsNoTracking()
                .Where(uc => uc.UserId == id)
                .Select(uc => uc.Chat)
                .Include(uc => uc.UsersSettings)
                .Include(uc => uc.UserChats)
                    .ThenInclude(uc => uc.User);

            var items = await chats.ToListAsync();

            if (items is IEnumerable<ISoftDeletable>)
            {
                items = items.Where(i => ((ISoftDeletable)i).IsDeleted == false).ToList();
            }

            return items;
        }

        public async Task<List<User>> GetUsersByChatId(int id)
        {
            IQueryable<User> users = _context.UserChat.AsNoTracking().Where(uc => uc.ChatId == id).Select(uc => uc.User);

            var items = await users.ToListAsync();

            if (items is IEnumerable<ISoftDeletable>)
            {
                items = items.Where(i => ((ISoftDeletable)i).IsDeleted == false).ToList();
            }

            return items;
        }

        public void Delete(string userId, int chatId)
        {
            IQueryable<UserChat> query = _dbSet.Include(c => c.User).Include(c => c.Chat);

            var entityToDelete = query.FirstOrDefault(e => e.ChatId == chatId && e.UserId == userId);

            if (entityToDelete == null) return;

            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }

            _dbSet.Remove(entityToDelete);
        }
    }
}