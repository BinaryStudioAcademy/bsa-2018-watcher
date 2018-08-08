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
            var tcs = new TaskCompletionSource<string>();
            Task.Run(() =>
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

                    var fileInfo = file.CopyTo(dirPath + @"\" + filename);

                    string newPath = dirPath + @"\" + filename;
                    tcs.SetResult(newPath);
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            });
            return tcs.Task;
        }
        public Task DeleteFileAsync(string path)
        {
            var tcs = new TaskCompletionSource<object>();
            Task.Run(() => {
                try
                {
                    var file = new FileInfo(path);
                    if (!file.Exists)
                        throw new ArgumentNullException("Invalid path");
                    file.Delete();
                    tcs.SetResult(null);
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            });
            return tcs.Task;
        }
    }
}
