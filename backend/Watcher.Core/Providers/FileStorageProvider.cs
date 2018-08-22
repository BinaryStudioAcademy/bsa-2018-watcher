using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    public class FileStorageProvider : IFileStorageProvider
    {
        private CloudStorageAccount StorageAccount;

        public FileStorageProvider(string ConnectionString)
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

            var filename = Guid.NewGuid().ToString()+Path.GetExtension(path);

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

        public async Task<string> UploadFileBase64Async(string base64string, string containerName)
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

            var azureUri = await UploadFileAsync(filePath);

            file.Delete();
            return azureUri;       
        }
    }
}
