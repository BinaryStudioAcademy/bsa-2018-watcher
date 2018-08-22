using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AutoMapper;

using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;

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
            var entity = await _repository.GetEntity(id);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<CollectedData, MemoryInfo>(entity);
            return info;
        }

        public async Task<List<PercentageInfo>> GetInstancePercentageInfo(Guid id, int count)
        {
            var entity = await _repository.GetPercentageInfoByEntityIdAsync(id, count);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<List<CollectedData>, List<PercentageInfo>>(entity);
            return info;
        }

        public async Task<ProcessesCpuInfo> GetInstanceProcessCpuInfo(Guid id)
        {
            var entity = await _repository.GetEntity(id);
            if (entity == null)
            {
                return null;
            }
            var info = _mapper.Map<CollectedData, ProcessesCpuInfo>(entity);
            return info;
        }

        public async Task<ProcessesRamInfo> GetInstanceProcessRamInfo(Guid id)
        {
            var entity = await _repository.GetEntity(id);
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
            var entity = await _repository.GetEntity(collectedDataDto.Id);
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

        public static CollectedData GetFakeData(Guid instanceId)
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
            var data = new CollectedData()
            {
                Id = instanceId, // Guid.Parse("7FE193DE-B3DC-4DF5-8646-A81EDBE047E2"), // instanceId
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
