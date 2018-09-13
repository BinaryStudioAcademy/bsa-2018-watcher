using System;
using System.IO;
using System.Threading.Tasks;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    using Microsoft.AspNetCore.Http;

    using Watcher.Common.Enums;
    using Watcher.Common.Helpers.Utils;

    public class LocalFileStorageProvider : IFileStorageProvider
    {
        public LocalFileStorageProvider() { }

        public async Task<string> UploadFormFileAsync(IFormFile formFile)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(formFile.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            }

            return path;
        }

        public async Task<string> UploadFormFileAsync(IFormFile formFile, OperatingSystems system)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(formFile.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            }

            return path;
        }

        public Task<string> UploadFileAsync(string path, string containerName = "watcher")
        {
            try
            {
                string parent = string.Copy(Directory.GetCurrentDirectory());
                while (new DirectoryInfo(parent).Name != "Watcher")
                {
                    parent = Directory.GetParent(parent).FullName;
                }

                var directory = new DirectoryInfo(Path.Combine(parent, "wwwroot", "images"));
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

        public Task<string> UploadFileFromStreamAsync(string url, string containerName = "watcher")
        {
            var imagePath = FileHelpers.DownloadImageFromUrl(url);
            var imageUri = ConvertToUri(imagePath);
            return Task.FromResult(imageUri);
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
            parent += @"\wwwroot\" + relativePath;
            return parent;
        }

        public Task<string> UploadFileBase64Async(string base64string, string imageType = "png", string containerName = "watcher")
        {
            try
            {
                string base64 = base64string.Split(',')[1];
                string parent = string.Copy(Directory.GetCurrentDirectory());
                while (new DirectoryInfo(parent).Name != "Watcher")
                {
                    parent = Directory.GetParent(parent).FullName;
                }

                var directory = new DirectoryInfo(Path.Combine(parent, "wwwroot", "images"));
                if (!directory.Exists) directory.Create();

                string filename = Guid.NewGuid().ToString() + ".png";

                File.WriteAllBytes(Path.Combine(directory.FullName, filename), Convert.FromBase64String(base64));
                var file = new FileInfo(directory + @"\\" + filename);

                string filePath = file.FullName;

                return Task.FromResult(ConvertToUri(filePath));
            }
            catch (Exception ex)
            {
                return Task.FromException<string>(ex);
            }
        }

        public Task<bool> IsExist(string path)
        {
            try
            {
                string parent = string.Copy(Directory.GetCurrentDirectory());
                while (new DirectoryInfo(parent).Name != "Watcher")
                {
                    parent = Directory.GetParent(parent).FullName;
                }

                var directory = new DirectoryInfo(Path.Combine(parent, "wwwroot", "images"));
                if (!directory.Exists) directory.Create();

                string filename = path;

                var file = new FileInfo(directory + @"\\" + filename);

                return Task.FromResult(file.Exists);
            }
            catch (Exception ex)
            {
                return Task.FromException<bool>(ex);
            }
        }
    }
}
