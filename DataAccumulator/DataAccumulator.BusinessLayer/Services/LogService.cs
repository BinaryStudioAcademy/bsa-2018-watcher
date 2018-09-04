using AutoMapper;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.Shared.Models;
using System.Threading.Tasks;

namespace DataAccumulator.BusinessLayer.Services
{
    public class LogService : ILogService
    {
        private readonly IMapper _mapper;
        private readonly ILogRepository _repository;

        public LogService(IMapper mapper, ILogRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task SaveActionLog(ActionLogDto actionLogDto)
        {
            var actionLog = _mapper.Map<ActionLogDto, ActionLog>(actionLogDto);

            await _repository.SaveActionLog(actionLog);
        }
    }
}
