using AutoMapper;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Watcher.Common.Dtos.Plots;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Services
{
    public class CollectedDataService: ICollectedDataService
    {
        private IDataAccumulatorRepository<CollectedData> _repository;
        private IMapper _mapper;

        public CollectedDataService(IDataAccumulatorRepository<CollectedData> repo, IMapper mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CollectedDataDto>> GetAllInstancesInfo()
        {
            var entities = await _repository.GetAllEntities();
            var collectedDtos = _mapper.Map<IEnumerable<CollectedData>, IEnumerable<CollectedDataDto>>(entities);
            return collectedDtos;
        }

        public async Task<MemoryInfo> GetInstanceMemoryInfo(Guid id)
        {
            var entity = await _repository.GetEntity(id);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<CollectedData, MemoryInfo>(entity);
            return info;
        }

        public async Task<PercentageInfo> GetInstancePercentageInfo(Guid id)
        {
            var entity = await _repository.GetEntity(id);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<CollectedData, PercentageInfo>(entity);
            return info;
        }

        public async Task<ProcessesCpuInfo> GetInstanceProcessCpuInfo(Guid id)
        {
            var entity = await _repository.GetEntity(id);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<CollectedData, ProcessesCpuInfo>(entity);
            return info;
        }

        public async Task<ProcessesRamInfo> GetInstanceProcessRamInfo(Guid id)
        {
            var entity = await _repository.GetEntity(id);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<CollectedData, ProcessesRamInfo>(entity);
            return info;
        }

        public async Task<CollectedDataDto> AddEntityAsync(CollectedDataDto collectedDataDto)
        {
            var mappedEntity = _mapper.Map<CollectedDataDto, CollectedData>(collectedDataDto);
            await _repository.AddEntity(mappedEntity);

            return collectedDataDto;
        }

        public async Task<CollectedDataDto> UpdateEntityAsync(CollectedDataDto collectedDataDto)
        {
            var entity = await _repository.GetEntity(collectedDataDto.Id);
            if (entity == null)
            {
                return null;
            }

            var mappedEntity = _mapper.Map<CollectedDataDto, CollectedData>(collectedDataDto);
            mappedEntity.InternalId = entity.InternalId;
            await _repository.UpdateEntity(mappedEntity);

            return collectedDataDto;
        }

        public async Task<bool> DeleteEntityAsync(Guid id)
        {
            if (!await _repository.EntityExistsAsync(id))
            {
                return false;
            }

            return await _repository.RemoveEntity(id);
        }
    }
}
