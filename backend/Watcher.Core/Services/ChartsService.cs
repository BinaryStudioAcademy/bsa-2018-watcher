namespace Watcher.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;

    public class ChartsService : IChartsService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ChartsService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ChartDto>> GetAllEntitiesAsync()
        {
            var chars = await _uow.ChartsRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<Chart>, List<ChartDto>>(chars);

            return dtos;
        }

        public async Task<ChartDto> GetEntityByIdAsync(int id)
        {
            var chart = await _uow.ChartsRepository.GetFirstOrDefaultAsync(s => s.Id == id);

            if (chart == null) return null;

            var dto = _mapper.Map<Chart, ChartDto>(chart);

            return dto;
        }

        public async Task<ChartDto> CreateEntityAsync(ChartRequest request)
        {
            var entity = _mapper.Map<ChartRequest, Chart>(request);
            // entity.Sources = 

            entity = await _uow.ChartsRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Chart, ChartDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(ChartRequest request, int id)
        {
            var entity = _mapper.Map<ChartRequest, Chart>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.ChartsRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            await _uow.ChartsRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
