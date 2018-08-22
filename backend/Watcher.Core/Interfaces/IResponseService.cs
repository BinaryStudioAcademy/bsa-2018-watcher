using System.Collections.Generic;
using System.Threading.Tasks;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;

namespace Watcher.Core.Interfaces
{
    public interface IResponseService
    {
        Task<IEnumerable<ResponseDto>> GetAllEntitiesAsync();

        Task<ResponseDto> GetEntityByIdAsync(int id);

        Task<ResponseDto> CreateEntityAsync(ResponseRequest request);
    }
}
