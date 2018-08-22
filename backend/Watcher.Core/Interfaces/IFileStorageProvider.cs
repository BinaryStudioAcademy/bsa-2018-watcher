using System.Threading.Tasks;

namespace Watcher.Core.Interfaces
{
    public interface IFileStorageProvider
    {
        Task<string> UploadFileAsync(string path, string containerName);
        Task<string> UploadFileBase64Async(string path, string containerName);
        Task DeleteFileAsync(string UriPath);
    }
}
