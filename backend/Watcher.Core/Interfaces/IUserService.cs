namespace Watcher.Core.Interfaces
{
    using System.Threading.Tasks;

    using Watcher.Common.Requests;

    public interface IUserService
    {
        Task<bool> UpdateEntityByIdAsync(UserRequest request, int id);
    }
}
