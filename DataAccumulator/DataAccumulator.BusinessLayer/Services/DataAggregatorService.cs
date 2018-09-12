using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Repositories;
using DataAccumulator.Shared.Exceptions;
using DataAccumulator.Shared.Models;
using Newtonsoft.Json;

namespace DataAccumulator.BusinessLayer.Services
{
    public class DataAggregatorService : IDataAggregatorService<CollectedDataDto>
    {
        private readonly IMapper _mapper;
        private readonly IDataAggregatorRepository<CollectedData> _repository;
        private readonly IAnomalyDetector _anomalyDetector;

        public DataAggregatorService(IMapper mapper, IDataAggregatorRepository<CollectedData> repository, IAnomalyDetector anomalyDetector)
        {
            _mapper = mapper;
            _repository = repository;
            _anomalyDetector = anomalyDetector;
        }

        public async Task<IEnumerable<CollectedDataDto>> GetEntitiesAsync()
        {
            var entities = await _repository.GetAllEntities();
            if (entities == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<IEnumerable<CollectedData>, IEnumerable<CollectedDataDto>>(entities);
        }

        public async Task<IEnumerable<CollectedDataDto>> GetEntitiesByTypeAsync(CollectedDataType collectedDataType)
        {
            var entities = await _repository.GetAllEntitiesByType(collectedDataType);
            if (entities == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<IEnumerable<CollectedData>, IEnumerable<CollectedDataDto>>(entities);
        }

        public async Task<CollectedDataDto> GetEntityAsync(Guid entityId)
        {
            var entity = await _repository.GetEntity(entityId);
            if (entity == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<CollectedData, CollectedDataDto>(entity);
        }

        public async Task<CollectedDataDto> AddEntityAsync(CollectedDataDto collectedDataDto)
        {
            if (collectedDataDto.Id == Guid.Empty)
            {
                collectedDataDto.Id = Guid.NewGuid();
            }

            var mappedEntity = _mapper.Map<CollectedDataDto, CollectedData>(collectedDataDto);
            await _repository.AddEntity(mappedEntity);

            return collectedDataDto;
        }

        public async Task<CollectedDataDto> UpdateEntityAsync(CollectedDataDto collectedDataDto)
        {
            var entity = await _repository.GetEntity(collectedDataDto.Id);
            if (entity == null)
            {
                throw new NotFoundException();
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
                throw new NotFoundException();
            }

            return await _repository.RemoveEntity(id);
        }

        public async Task<AzureMLAnomalyReport> RunMl(Guid id)
        {
            var data = await _repository.GetEntitiesByInstanceIdAndTypeInTime(id, CollectedDataType.Accumulation, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1), count: 1000);
            return await _anomalyDetector.AnalyzeData(data);
        }
    }
}
