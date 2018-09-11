using System;
using System.Threading.Tasks;

using AutoMapper;

using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.Shared.Models;
using DataAccumulator.Shared.Enums;

using ServiceBus.Shared.Messages;
using ServiceBus.Shared.Enums;

namespace DataAccumulator.BusinessLayer.Services
{
    public class LogService : ILogService
    {
        private readonly IMapper _mapper;
        private readonly ILogRepository _repository;
        private readonly IServiceBusProvider _serviceBusProvider;

        public LogService(IMapper mapper, ILogRepository repository, IServiceBusProvider serviceBusProvider)
        {
            _mapper = mapper;
            _repository = repository;
            _serviceBusProvider = serviceBusProvider;
        }

        public async Task SaveActionLog(ActionLogDto actionLogDto)
        {
            if (actionLogDto?.Id == Guid.Empty)
            {
                actionLogDto.Id = Guid.NewGuid();
            }

            var actionLog = _mapper.Map<ActionLogDto, ActionLog>(actionLogDto);

            if (actionLog.LogLevel != LogLevel.Info)
            {
                var message = new InstanceNotificationMessage()
                {
                    InstanceId = actionLog.ClientId,
                    Text = actionLog.Message,
                    CreatedAt = actionLog.Timestamp,
                    Type = (NotificationType)actionLog.LogLevel
                };

                // Send log to backend like notification
                await _serviceBusProvider.SendNotificationMessage(message);
            }

            //await _repository.AddEntity(actionLog);
        }
    }
}
