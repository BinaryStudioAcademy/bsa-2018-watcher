namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;

    using DataAccumulator.Shared.Models;
    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;

    using Watcher.Core.Interfaces;

    public class AggregatedDataService: IAggregateDataService
    {

        private IDataAggregatorRepository<CollectedData> _repository;
        private IMapper _mapper;

        public AggregatedDataService(IDataAggregatorRepository<CollectedData> repo, IMapper mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CollectedDataDto>> GetAggregatedDataInTime(Guid id, CollectedDataType collectedDataType, DateTime timeFrom, DateTime timeTo,
                                                                                                                                int page = 1, int count = 10)
        {
            var entities =
                await _repository.GetEntitiesByInstanceIdAndTypeInTime(id, collectedDataType, timeFrom, timeTo, page, count);
            var collectedDtos = _mapper.Map<IEnumerable<CollectedData>, IEnumerable<CollectedDataDto>>(entities);
            return collectedDtos;
        }

        public async Task<long> GetCountOfEntities(Guid id, CollectedDataType collectedDataType, DateTime timeFrom, DateTime timeTo)
        {
            var count =
                await _repository.GetCountOfEntities(id, collectedDataType, timeFrom, timeTo);
            return count;
        }
    }
}
