using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Watcher.Common.Helpers.Utils
{
    using System.IO;
    using System.Threading.Tasks;

    public static class FileHelpers
    {
        public static async Task<string> DownloadImageFromUrl(string url)
        {
            using (WebClient client = new WebClient())
            {
                string parent = string.Copy(Directory.GetCurrentDirectory());
                while (new DirectoryInfo(parent).Name != "Watcher")
                {
                    parent = Directory.GetParent(parent).FullName;
                }

                string imagePath = Path.Combine(parent, "wwwroot", "images", "profilePhoto.png");

                client.DownloadFile(new Uri(url), imagePath);
                return imagePath;
            }
        }

        public static Task DeleteFileByPath(string path)
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