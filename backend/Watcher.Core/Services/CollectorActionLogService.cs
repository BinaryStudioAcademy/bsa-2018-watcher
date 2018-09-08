using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Watcher.Core.Interfaces;
using DataAccumulator.Shared.Models;
using AutoMapper;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Entities;

namespace Watcher.Core.Services
{
    public class CollectorActionLogService : ICollectorActionLogService
    {
        private readonly IMapper _mapper;
        private readonly ILogRepository _repository;

        public CollectorActionLogService(IMapper mapper, ILogRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IEnumerable<ActionLogDto>> GetAllLogs(Guid instanceId)
        {
            var entities = await _repository.GetAllLogs(instanceId);

            var dtos = _mapper.Map<IEnumerable<ActionLog>, IEnumerable<ActionLogDto>>(entities);

            return dtos;
        }
    }
}
