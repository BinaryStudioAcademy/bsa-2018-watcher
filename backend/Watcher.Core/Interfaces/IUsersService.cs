namespace Watcher.Core.Interfaces
{
    using System.Threading.Tasks;

    using Watcher.Common.Requests;

    public interface IUsersService
    {
        Task<bool> UpdateEntityByIdAsync(UserRequest request, int id);
    }
}
