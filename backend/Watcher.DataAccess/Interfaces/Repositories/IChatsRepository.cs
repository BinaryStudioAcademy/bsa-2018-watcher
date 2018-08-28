namespace Watcher.DataAccess.Interfaces.Repositories
{
    using System;
    using System.Linq.Expressions;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.DataAccess.Entities;

    public interface IChatsRepository : IRepository<Chat, int>
    {
        Task<List<Chat>> GetChatsByUserId(string id, Expression<Func<Chat, bool>> filter = null);

        Task<List<User>> GetUsersByChatId(int id);

        Task<UserChat> AddUserChat(UserChat userChat);

        Task DeleteUserChat(UserChat userChat);
    }
}
