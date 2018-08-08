using System;
using System.IO;
using System.Threading.Tasks;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    public class LocalFileStorageProvider:IFileStorageProvider
    {
        string defaultPath;
        public LocalFileStorageProvider(string path)
        {
            defaultPath = path;
        }
        public Task<string> UploadFileAsync(string path, string containerName = "watcher")
        {
            try
            {
                string dirPath = defaultPath + containerName;

                var directory = new DirectoryInfo(dirPath);
                if (!directory.Exists) directory.Create();

                var file = new FileInfo(path);

                if (!file.Exists)
                    throw new ArgumentNullException("Invalid path");

                string filename = Guid.NewGuid().ToString() + Path.GetExtension(path);

                var fileInfo = file.CopyTo(dirPath + @"\\" + filename);

                string newPath = dirPath + @"\\" + filename;
                return Task.FromResult<string>(newPath);
            }
            catch(Exception ex)
            {
                return Task.FromException<string>(ex);
            }
        }
        public Task DeleteFileAsync(string path)
        {
            try
            {
                var file = new FileInfo(path);
                if (!file.Exists)
                    throw new ArgumentNullException("Invalid path");
                file.Delete();
                return Task.FromResult<object>(null);
            }
            catch (Exception ex)
            {
                return Task.FromException<object>(ex);
            }
        }
    }
}
