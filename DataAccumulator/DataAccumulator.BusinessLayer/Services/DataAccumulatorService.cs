using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.Shared.Exceptions;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.BusinessLayer.Services
{
    using ServiceBus.Shared.Messages;

    public class DataAccumulatorService : IDataAccumulatorService<CollectedDataDto>
    {
        private readonly IMapper _mapper;
        private readonly IDataAccumulatorRepository<CollectedData> _repository;
        private readonly IServiceBusProvider _serviceBusProvider;

        public DataAccumulatorService(IMapper mapper,
                                      IDataAccumulatorRepository<CollectedData> repository,
                                      IServiceBusProvider serviceBusProvider)
        {
            _mapper = mapper;
            _repository = repository;
            _serviceBusProvider = serviceBusProvider;
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

        public async Task<CollectedDataDto> GetEntityAsync(Guid entityId)
        {
            var entity = await _repository.GetEntityByInstanceIdAsync(entityId);
            if (entity == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<CollectedData, CollectedDataDto>(entity);
        }

        public async Task<CollectedDataDto> AddEntityAsync(CollectedDataDto collectedDataDto)
        {
            if (collectedDataDto?.Id == Guid.Empty)
            {
                collectedDataDto.Id = Guid.NewGuid();
            }

            var mappedEntity = _mapper.Map<CollectedDataDto, CollectedData>(collectedDataDto);
            await _repository.AddEntity(mappedEntity);

            var message = new InstanceCollectedDataMessage
            {
                CollectedDataId = mappedEntity.Id,
                InstanceId = mappedEntity.ClientId
            };
            await _serviceBusProvider.SendDataMessage(message);


            return collectedDataDto;
        }

        public async Task<CollectedDataDto> AddEntityAsync()
        {
            var mappedEntity = GetFakeData(Guid.NewGuid(), Guid.Parse("7FE193DE-B3DC-4DF5-8646-A81EDBE047E2"));
            await _repository.AddEntity(mappedEntity);
            
            await _serviceBusProvider.SendDataMessage(mappedEntity.ClientId, mappedEntity.Id);

            return null;
        }

        public async Task<CollectedDataDto> UpdateEntityAsync(CollectedDataDto collectedDataDto)
        {
            var entity = await _repository.GetEntityByInstanceIdAsync(collectedDataDto.Id);
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

        public static CollectedData GetFakeData(Guid collectedDataId, Guid instanceId)
        {
            var processNames = new List<string>()
                                   {
                                       "Google_Chrome",
                                       "Steam_updater",
                                       "explorer",
                                       "devenv",
                                       "Telegram",
                                       "slack",
                                       "zoom",
                                       "mongodbcompass"
                                   };
            var random = new Random();
            var ProcessesCPU = new Dictionary<string, float>();
            var ProcessesRAM = new Dictionary<string, float>();

            int processes = random.Next(0, 7);
            for (int i = 0; i < processes; i++)
            {
                ProcessesCPU.Add(processNames[i], (float)random.NextDouble() * 10);
                ProcessesRAM.Add(processNames[i], (float)random.NextDouble() * 1000);
            }
            var data = new CollectedData
            {
                Id = collectedDataId,
                ClientId = instanceId, // Guid.Parse("7FE193DE-B3DC-4DF5-8646-A81EDBE047E2"), // instanceId
                Time = DateTime.UtcNow,
                CpuUsagePercent = (float)Math.Round(random.NextDouble() * 100, 2),
                RamUsagePercent = (float)Math.Round(random.NextDouble() * 100, 2),
                InterruptsTimePercent = (float)Math.Round(random.NextDouble() * 100, 2),
                LocalDiskFreeSpacePercent = (float)Math.Round(random.NextDouble() * 100, 2),
                AvaliableRamBytes = random.Next(100, 4096),
                InterruptsPerSeconds = random.Next(0, 100),
                LocalDiskFreeMBytes = random.Next(0, 1000000000),
                ProcessesCPU = ProcessesCPU,
                ProcessesRAM = ProcessesRAM,
                ProcessesCount = random.Next(0, 300)
            };

            return data;
        }
    }
}
