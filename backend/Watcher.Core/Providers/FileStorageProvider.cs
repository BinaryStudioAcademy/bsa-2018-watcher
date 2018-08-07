using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Watcher.Core.Providers
{
    public class FileStorageProvider
    {
        private CloudStorageAccount StorageAccount;

        public FileStorageProvider(string ConnectionString)
        {
            this.StorageAccount = CloudStorageAccount.Parse(ConnectionString);
        }

        public async Task<string> UploadFileAsync(string path, string containerName = "watcher", string filename = "")
        {
            var client = StorageAccount.CreateCloudBlobClient();

            var container = client.GetContainerReference(containerName.ToLower());

            if ((await container.ExistsAsync()) == false)
            {
                await container.CreateAsync();
            }

            filename = filename == "" ? GetUniqueName(Path.GetFileName(path)) :
                GetUniqueName(filename);

            var blob = container.GetBlockBlobReference(filename);

            await SetPublicContainerPermissions(container);

            await blob.UploadFromFileAsync(path);

            return blob.Uri.ToString();
        }

        private async Task SetPublicContainerPermissions(CloudBlobContainer container)
        {
            BlobContainerPermissions permissions = new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            };
            await container.SetPermissionsAsync(permissions);
        }

        private string GetUniqueName(string filename)
        {
            var GuidPrefix = Guid.NewGuid().ToString();
            filename = GuidPrefix + "-" + filename;
            return filename;
        }
    }
}
