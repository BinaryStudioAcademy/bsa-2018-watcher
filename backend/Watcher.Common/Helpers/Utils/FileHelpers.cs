using System;
using System.Net;

namespace Watcher.Common.Helpers.Utils
{
    public static class FileHelpers
    {
        public static string DownloadImageFromUrl(string url)
        {
            using (WebClient client = new WebClient())
            {
                string imagePath = @"c:\temp\profilePhoto.png";
                client.DownloadFile(new Uri(url), imagePath);
                return imagePath;
            }
        }
    }
}