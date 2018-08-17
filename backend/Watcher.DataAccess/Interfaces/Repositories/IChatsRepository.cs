namespace Watcher.DataAccess.Interfaces.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.DataAccess.Entities;

    public interface IChatsRepository : IRepository<Chat, int>
    {
        Task<List<Chat>> GetChatsByUserId(string id);

        Task<List<User>> GetUsersByChatId(int id);

        Task<UserChat> AddUserChat(UserChat userChat);
    }
}
