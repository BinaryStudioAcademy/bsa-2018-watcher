namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Enums;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;

    public class SamplesService : ISamplesService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public SamplesService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SampleDto>> GetAllEntitiesAsync()
        {
            var samples = await _uow.SamplesRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<Sample>, List<SampleDto>>(samples);

            return dtos;
        }

        public async Task<SampleDto> GetEntityByIdAsync(int id)
        {
            var sample = await _uow.SamplesRepository.GetFirstOrDefaultAsync(s => s.Id == id);

            if (sample == null) return null;

            var dto = _mapper.Map<Sample, SampleDto>(sample);

            return dto;
        }

        public async Task<SampleDto> CreateEntityAsync(SampleRequest request)
        {
            var entity = _mapper.Map<SampleRequest, Sample>(request);

            entity = await _uow.SamplesRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Sample, SampleDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(SampleRequest request, int id)
        {
            var entity = _mapper.Map<SampleRequest, Sample>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.SamplesRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            await _uow.SamplesRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
