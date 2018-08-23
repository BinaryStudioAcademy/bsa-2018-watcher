using System.Threading.Tasks;

namespace Watcher.Core.Interfaces
{
    public interface IFileStorageProvider
    {
        Task<string> UploadFileAsync(string path, string containerName = "watcher");

        Task<string> UploadFileFromStreamAsync(string url, string containerName = "watcher");
        Task<string> UploadFileBase64Async(string base64string, string imageType = "png", string containerName = "watcher");
        Task DeleteFileAsync(string UriPath);
    }
}
