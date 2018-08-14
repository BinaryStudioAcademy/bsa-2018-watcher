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

        public async Task<IEnumerable<Chat>> GetChatsByUserId(string id)
        {
            IQueryable<Chat> chats = Context.UserChats.Where(uc => uc.UserId == id).Select(uc => uc.Chat);

            return await chats.ToListAsync();
        }
    }
}
