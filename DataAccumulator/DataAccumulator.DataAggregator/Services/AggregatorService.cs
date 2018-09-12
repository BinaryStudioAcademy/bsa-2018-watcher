using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.Shared.Exceptions;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator.Services
{
    public class AggregatorService : IAggregatorService<CollectedDataDto>
    {
        private readonly IMapper _mapper;
        private readonly IDataAggregatorRepository<CollectedData> _dataAggregatorRepository;
        private readonly IInstanceSettingsRepository<InstanceSettings> _instanceSettingsRepository;

        public AggregatorService(IMapper mapper,
            IDataAggregatorRepository<CollectedData> dataAggregatorRepository,
            IInstanceSettingsRepository<InstanceSettings> instanceSettingsRepository)
        {
            _mapper = mapper;
            _dataAggregatorRepository = dataAggregatorRepository;
            _instanceSettingsRepository = instanceSettingsRepository;
        }

        public async Task<IEnumerable<CollectedDataDto>> GetSourceEntitiesAsync(CollectedDataType sourceType, 
            DateTime timeFrom, DateTime timeTo)
        {
            var entities = await _dataAggregatorRepository.GetEntitiesByTypeInTime(sourceType, timeFrom, timeTo);
            if (entities == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<IEnumerable<CollectedData>, IEnumerable<CollectedDataDto>>(entities);
        }

        public async Task<bool> DeleteAggregatedEntityAsync(Guid id)
        {
            if (!await _dataAggregatorRepository.EntityExistsAsync(id))
            {
                throw new NotFoundException();
            }

            return await _dataAggregatorRepository.RemoveEntity(id);
        }

        public async Task<CollectedDataDto> AddAggregatorEntityAsync(CollectedDataDto collectedDataDto)
        {
            if (collectedDataDto.Id == Guid.Empty)
            {
                collectedDataDto.Id = Guid.NewGuid();
            }

            var mappedEntity = _mapper.Map<CollectedDataDto, CollectedData>(collectedDataDto);
            await _dataAggregatorRepository.AddEntity(mappedEntity);

            return collectedDataDto;
        }

        public async Task<IEnumerable<InstanceSettingsDto>> GetInstanceSettingsEntitiesAsync()
        {
            var entities = await _instanceSettingsRepository.GetAllEntitiesAsync();
            if (entities == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<IEnumerable<InstanceSettings>, IEnumerable<InstanceSettingsDto>>(entities);
        }
    }
}
