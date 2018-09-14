using Watcher.Common.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Watcher.Core.Interfaces
{
    public interface IThemeService
    {
        Task<IEnumerable<ThemeDto>> GetAllEntitiesAsync();

        Task<ThemeDto> GetById(int id);

        Task<ThemeDto> CreateEntityAsync(ThemeDto themeDto);
    }
}
