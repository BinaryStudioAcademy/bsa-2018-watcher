using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Watcher.Core.Interfaces
{
    public interface IFileStorageService
    {
        Task<string> UploadFileAsync(string path, string containerName);
        Task DeleteFileAsync(string UriPath);
    }
}
