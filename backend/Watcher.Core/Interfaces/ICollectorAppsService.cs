namespace Watcher.Core.Interfaces
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface ICollectorAppsService
    {
        Task<string> UploadFileToStorage(IFormFile file);
        Task<CollectorAppVersionDto> CreateEntityAsync(CollectorAppVersionRequest request);

        Task<CollectorAppVersionDto> GetActiveEntityAsync();

        Task<List<CollectorAppVersionDto>> GetAllEntityesAsync();

        Task<bool> DeleteEntityAsync(int id);
    }
}
