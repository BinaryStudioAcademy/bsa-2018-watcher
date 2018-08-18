using AutoMapper;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Watcher.Common.Dtos;
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

        public async Task<CollectedDataDto> GetInstanceInfo(Guid id)
        {
            var collectedDataRaw = await _repository.GetEntity(id);
            var collectedDto = _mapper.Map<CollectedData, CollectedDataDto>(collectedDataRaw);
            return collectedDto;
        }
    }
}
