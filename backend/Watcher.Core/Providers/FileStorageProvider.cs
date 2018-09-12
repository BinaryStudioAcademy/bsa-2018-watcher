using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    using System.Net.Http;

    using Microsoft.AspNetCore.Http;

    using Watcher.Common.Enums;
    using Watcher.Common.Helpers.Utils;

    public class FileStorageProvider : IFileStorageProvider
    {
        private CloudStorageAccount _storageAccount;

        public FileStorageProvider(string connectionString)
        {
            _storageAccount = CloudStorageAccount.Parse(connectionString);
        }

        public async Task<string> UploadFormFileAsync(IFormFile formFile)
        {
            var client = _storageAccount.CreateCloudBlobClient();

            var container = client.GetContainerReference("watcher");

            if (await container.ExistsAsync() == false)
            {
                await container.CreateAsync();
            }

            var filename = Guid.NewGuid() + Path.GetExtension(formFile.FileName);
            var blob = container.GetBlockBlobReference(filename);

            await SetPublicContainerPermissions(container);

            using (var stream = formFile.OpenReadStream())
            {
                await blob.UploadFromStreamAsync(stream);
            }

            return blob.Uri.ToString();
        }

        public async Task<string> UploadFormFileWithNameAsync(IFormFile formFile)
        {
            var client = _storageAccount.CreateCloudBlobClient();

            var container = client.GetContainerReference("watcher");

            if (await container.ExistsAsync() == false)
            {
                await container.CreateAsync();
            }

            CloudBlockBlob blob = container.GetBlockBlobReference(formFile.FileName);

            await SetPublicContainerPermissions(container);

            using (var stream = formFile.OpenReadStream())
            {
                await blob.UploadFromStreamAsync(stream);
            }

            return blob.Uri.ToString();
        }

        public async Task<string> UploadFileAsync(string path, string containerName = "watcher")
        {
            var client = _storageAccount.CreateCloudBlobClient();

            var container = client.GetContainerReference(containerName.ToLower());

            if (await container.ExistsAsync() == false)
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
            var client = _storageAccount.CreateCloudBlobClient();

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
                return "https://bsawatcherfiles.blob.core.windows.net/watcher/9c2c0291-728d-4e7b-bcb7-3b9432cb8733.png"; // Return base pic
            }

            var filename = $"{Guid.NewGuid()}.{imageFormat}";

            var base64 = base64string.Split(',')[1];
            var imageInBytes = Convert.FromBase64String(base64);
            var client = _storageAccount.CreateCloudBlobClient();

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
            var client = _storageAccount.CreateCloudBlobClient();
            var blob = await client.GetBlobReferenceFromServerAsync(new Uri(path));

            //will throw exception if there is no blob
            await blob.DeleteAsync();
        }

        private Task SetPublicContainerPermissions(CloudBlobContainer container)
        {
            var permissions = new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            };

            return container.SetPermissionsAsync(permissions);
        }
    }
}
