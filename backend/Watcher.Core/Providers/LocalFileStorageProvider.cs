using System;
using System.IO;
using System.Threading.Tasks;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    public class LocalFileStorageProvider:IFileStorageProvider
    {
        public LocalFileStorageProvider()
        { }

        public Task<string> UploadFileAsync(string path, string containerName = "watcher")
        {
            try
            {
                string parent = string.Copy(Directory.GetCurrentDirectory());
                while (new DirectoryInfo(parent).Name != "Watcher")
                {
                    parent = Directory.GetParent(parent).FullName;
                }

                var directory = new DirectoryInfo(parent + @"\" + "content");
                if (!directory.Exists) directory.Create();

                var file = new FileInfo(path);

                if (!file.Exists)
                    throw new ArgumentNullException("Invalid path");

                string filename = Guid.NewGuid().ToString() + Path.GetExtension(path);

                var fileInfo = file.CopyTo(directory + @"\\" + filename);

                string newPath = fileInfo.FullName;

                return Task.FromResult(ConvertToUri(newPath));
            }
            catch (Exception ex)
            {
                return Task.FromException<string>(ex);
            }
        }

        public Task DeleteFileAsync(string path)
        {
            try
            {
                path = ConvertToAbsolutePath(path);

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

        private string ConvertToUri(string path)
        {
            Uri uri1 = new Uri(path);
            Uri uri2 = new Uri(new FileInfo(path).Directory.Parent.FullName + @"\" + "frontend");
            Uri relativeUri = uri2.MakeRelativeUri(uri1);
            return relativeUri.ToString();
        }

        private string ConvertToAbsolutePath(string relativePath)
        {
            string parent = string.Copy(Directory.GetCurrentDirectory());
            while (new DirectoryInfo(parent).Name != "Watcher")
            {
                parent = Directory.GetParent(parent).FullName;
                if (parent == Directory.GetDirectoryRoot(parent)) throw new ArgumentNullException("Wrong relative path");
            }
            parent += @"\" + relativePath;
            return parent;
        }
    }
}
