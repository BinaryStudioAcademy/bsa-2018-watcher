namespace Watcher.Core.Interfaces
{
    using Microsoft.AspNetCore.Http;
    using System.Threading.Tasks;

    public interface ICollectorAppsService
    {
        Task<string> UploadFileToStorage(IFormFile file);
    }
}
