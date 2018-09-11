namespace Watcher.DataAccess.Interfaces.Repositories
{
    using System;
    using System.Threading.Tasks;

    using Watcher.DataAccess.Entities;

    public interface IInstanceRepository : IRepository<Instance, int>
    {
        Task<Instance> UpateLastCheckedAsync(Guid instanceId, DateTime time);
    }
}