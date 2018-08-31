namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface IChartsService
    {
        Task<IEnumerable<ChartDto>> GetAllEntitiesAsync();

        Task<ChartDto> GetEntityByIdAsync(int id);

        Task<ChartDto> CreateEntityAsync(ChartDto request); /*ChartRequest */

        Task<bool> UpdateEntityByIdAsync(ChartRequest request, int id);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}