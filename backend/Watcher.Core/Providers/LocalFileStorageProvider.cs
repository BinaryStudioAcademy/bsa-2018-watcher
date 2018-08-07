using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    public class LocalFileStorageProvider : IFileStorageProvider
    {
        public LocalFileStorageProvider(string ConnectionString)
        {

        }

        public Task DeleteFileAsync(string UriPath)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadFileAsync(string path, string containerName)
        {
            throw new NotImplementedException();
        }
    }
}
