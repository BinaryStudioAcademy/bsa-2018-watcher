using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AutoMapper;

using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.Shared.Models;
using Watcher.Common.Dtos.Plots;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Services
{
    public class CollectedDataService : ICollectedDataService
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
            var entity = await _repository.GetEntityByInstanceIdAsync(id);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<CollectedData, MemoryInfo>(entity);
            return info;
        }

        public async Task<List<PercentageInfo>> GetInstancePercentageInfo(Guid id, int count)
        {
            var entity = await _repository.GetPercentageInfoByInstanceIdAsync(id, count);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<List<CollectedData>, List<PercentageInfo>>(entity);
            return info;
        }

        public async Task<List<CollectedDataDto>> GetCollectedDataByInstanceId(Guid id, int count)
        {
            // Get collected data for instance for the last 3 minutes(~24 items)
            //var entities = await _repository.GetCollectedDataByInstanceIdAsync(id, DateTime.UtcNow.AddMinutes(-3), DateTime.UtcNow);
            var entities = await _repository.GetCollectedDataByInstanceIdAsync(id, count);

            if (entities == null)
            {
                return null;
            }
            var dtos = _mapper.Map<IEnumerable<CollectedData>, List<CollectedDataDto>>(entities);
            return dtos;
        }

        public async Task<ProcessesCpuInfo> GetInstanceProcessCpuInfo(Guid id)
        {
            var entity = await _repository.GetEntityByInstanceIdAsync(id);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<CollectedData, ProcessesCpuInfo>(entity);
            return info;
        }

        public async Task<ProcessesRamInfo> GetInstanceProcessRamInfo(Guid id)
        {
            var entity = await _repository.GetEntityByInstanceIdAsync(id);
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
            var entity = await _repository.GetEntityByInstanceIdAsync(collectedDataDto.Id);
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

        public static CollectedData GetFakeData(Guid instanceId, DateTime dateTime)
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
            var processData = new List<ProcessData>();

            int processes = random.Next(0, 7);
            for (int i = 0; i < processes; i++)
            {
                //ProcessesCPU.Add(processNames[i], (float)random.NextDouble() * 10);
                processData.Add(new ProcessData()
                {
                    Name = processNames[i],
                    RamMBytes = (float)random.NextDouble() * 10,
                    PRam = (float)random.NextDouble() * 10,
                    PCpu = (float)random.NextDouble() * 10
                });
            }
            var data = new CollectedData
            {
                Id = Guid.NewGuid(),
                ClientId = instanceId, // Guid.Parse("7FE193DE-B3DC-4DF5-8646-A81EDBE047E2"), // instanceId
                CollectedDataType = CollectedDataType.Accumulation,
                Time = dateTime,
                ProcessesCount = random.Next(10, 300),
                CpuUsagePercentage = (float)random.NextDouble() * 10,
                UsageRamMBytes = random.Next(0, 5_000), // (float)Math.Round(random.NextDouble() * 100, 2),
                TotalRamMBytes = random.Next(5_000, 10_000), // (float)Math.Round(random.NextDouble() * 100, 2) + (float)Math.Round(random.NextDouble() * 100, 2),
                RamUsagePercentage = (float)Math.Round(random.NextDouble() * 100, 2),
                InterruptsPerSeconds = random.Next(100, 4096),
                LocalDiskUsageMBytes = random.Next(0, 5000),
                LocalDiskTotalMBytes = random.Next(5000, 1_000_000),
                LocalDiskUsagePercentage = random.Next(0, 100),
                Processes = processData
            };

            return data;
        }
    }
}
