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
        private readonly IDataAccumulatorRepository<CollectedData> _dataAccumulatorRepository;
        private readonly IDataAggregatorRepository<CollectedData> _dataAggregatorRepository;

        public AggregatorService(IMapper mapper,
            IDataAccumulatorRepository<CollectedData> dataAccumulatorRepository,
            IDataAggregatorRepository<CollectedData> dataAggregatorRepository)
        {
            _mapper = mapper;
            _dataAccumulatorRepository = dataAccumulatorRepository;
            _dataAggregatorRepository = dataAggregatorRepository;
        }

        public async Task<IEnumerable<CollectedDataDto>> GetAccumulatorEntitiesAsync(DateTime timeFrom, DateTime timeTo)
        {
            var entities = await _dataAccumulatorRepository.GetEntities(timeFrom, timeTo);
            if (entities == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<IEnumerable<CollectedData>, IEnumerable<CollectedDataDto>>(entities);
        }

        public async Task<bool> DeleteAccumulatorEntityAsync(Guid id)
        {
            if (!await _dataAccumulatorRepository.EntityExistsAsync(id))
            {
                throw new NotFoundException();
            }

            return await _dataAccumulatorRepository.RemoveEntity(id);
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

       
    }
}
