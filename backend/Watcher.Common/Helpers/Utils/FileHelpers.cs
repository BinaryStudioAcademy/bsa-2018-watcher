using System;
using System.Net;

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
                //string parent = string.Copy(Directory.GetCurrentDirectory());
                //while (new DirectoryInfo(parent).Name != "Watcher")
                //{
                //    parent = Directory.GetParent(parent).FullName;
                //}

                //var directory = new DirectoryInfo(Path.Combine(parent, "wwwroot", "images"));
                //if (!directory.Exists) directory.Create();

                //string filename = Guid.NewGuid().ToString() + ".png";

                //File.WriteAllBytes(Path.Combine(directory.FullName, filename), Convert.FromBase64String(base64));
                //var file = new FileInfo(directory + @"\\" + filename);

                //string filePath = file.FullName;

                //var azureUri = await UploadFileAsync(filePath);

                string imagePath = @"c:\temp\profilePhoto.png";
                client.DownloadFile(new Uri(url), imagePath);
                return imagePath;
            }
        }
    }
}