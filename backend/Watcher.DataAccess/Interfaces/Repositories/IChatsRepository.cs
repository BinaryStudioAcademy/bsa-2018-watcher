namespace Watcher.DataAccess.Interfaces.Repositories
{
    using System;
    using System.Linq.Expressions;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.DataAccess.Entities;

    public interface IChatsRepository : IRepository<Chat, int>
    {
    }
}
