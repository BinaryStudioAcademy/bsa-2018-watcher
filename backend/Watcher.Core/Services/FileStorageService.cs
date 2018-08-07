using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    public class FileStorageService:IFileStorageService
    {
        private CloudStorageAccount StorageAccount;

        public FileStorageService(string ConnectionString)
        {
            this.StorageAccount = CloudStorageAccount.Parse(ConnectionString);
        }

        public async Task<string> UploadFileAsync(string path, string containerName = "watcher")
        {
            var client = StorageAccount.CreateCloudBlobClient();

            var container = client.GetContainerReference(containerName.ToLower());

            if ((await container.ExistsAsync()) == false)
            {
                await container.CreateAsync();
            }

            var filename = Guid.NewGuid().ToString();

            var blob = container.GetBlockBlobReference(filename);

            await SetPublicContainerPermissions(container);

            await blob.UploadFromFileAsync(path);

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
            BlobContainerPermissions permissions = new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            };
            await container.SetPermissionsAsync(permissions);
        }
    }
}
