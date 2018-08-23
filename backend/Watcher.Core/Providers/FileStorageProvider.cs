using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    using System.Net.Http;

    using Watcher.Common.Helpers.Utils;

    public class FileStorageProvider : IFileStorageProvider
    {
        private CloudStorageAccount StorageAccount;

        public FileStorageProvider(string ConnectionString)
        {
            StorageAccount = CloudStorageAccount.Parse(ConnectionString);
        }

        public async Task<string> UploadFileAsync(string path, string containerName = "watcher")
        {
            var client = StorageAccount.CreateCloudBlobClient();

            var container = client.GetContainerReference(containerName.ToLower());

            if ((await container.ExistsAsync()) == false)
            {
                await container.CreateAsync();
            }

            var filename = Guid.NewGuid() + Path.GetExtension(path);

            var blob = container.GetBlockBlobReference(filename);

            await SetPublicContainerPermissions(container);

            await blob.UploadFromFileAsync(path);

            return blob.Uri.ToString();
        }

        public async Task<string> UploadFileFromStreamAsync(string url, string containerName = "watcher")
        {
            var client = StorageAccount.CreateCloudBlobClient();

            var container = client.GetContainerReference(containerName.ToLower());

            if ((await container.ExistsAsync()) == false)
            {
                await container.CreateAsync();
            }

            var filename = Guid.NewGuid() + Path.GetExtension(url);
            CloudBlockBlob blob = null;
            using (var httpClient = new HttpClient())
            {
                var stream = await httpClient.GetStreamAsync(url);

                blob = container.GetBlockBlobReference(filename);

                await SetPublicContainerPermissions(container);

                await blob.UploadFromStreamAsync(stream);
            }

            return blob.Uri.ToString();
        }

        public async Task<string> UploadFileBase64Async(string base64string, string imageType = "image/png", string containerName = "watcher")
        {
            // Check if file if supported image format
            if (!ImageHelper.ImageFormats.TryGetValue(imageType, out var imageFormat))
            {
                return "https://bsawatcherfiles.blob.core.windows.net/watcher/f6efd981-4e08-44f0-ab87-837720b372ef.png"; // Return base pic
            }

            var filename = $"{Guid.NewGuid()}.{imageFormat}";

            var base64 = base64string.Split(',')[1];
            var imageInBytes = Convert.FromBase64String(base64);
            var client = StorageAccount.CreateCloudBlobClient();

            var container = client.GetContainerReference(containerName.ToLower());

            if (await container.ExistsAsync() == false)
            {
                await container.CreateAsync();
            }

            var blob = container.GetBlockBlobReference(filename);

            await SetPublicContainerPermissions(container);

            await blob.UploadFromByteArrayAsync(imageInBytes, 0, imageInBytes.Length);

            return blob.Uri.ToString();
        }

        public async Task DeleteFileAsync(string path)
        {
            var client = StorageAccount.CreateCloudBlobClient();
            var blob = await client.GetBlobReferenceFromServerAsync(new Uri(path));

            //will throw exception if there is no blob
            await blob.DeleteAsync();
        }

        private async Task SetPublicContainerPermissions(CloudBlobContainer container)
        {
            var permissions = new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            };

            await container.SetPermissionsAsync(permissions);
        }
    }
}
