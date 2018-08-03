namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface ISamplesService
    {
        Task<IEnumerable<SampleDto>> GetAllEntitiesAsync();
        
        Task<SampleDto> GetEntityByIdAsync(int id);

        Task<SampleDto> CreateEntityAsync(SampleRequest request);

        Task<bool> UpdateEntityByIdAsync(SampleRequest request, int id);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}