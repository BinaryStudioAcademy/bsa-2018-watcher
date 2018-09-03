using System;
using System.Linq;
using System.Threading.Tasks;
using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator
{
    public class DataAggregatorCore : IDataAggregatorCore<CollectedDataDto>
    {
        private readonly IAggregatorService<CollectedDataDto> _aggregatorService;

        public DataAggregatorCore(IAggregatorService<CollectedDataDto> aggregatorService)
        {
            _aggregatorService = aggregatorService;
        }

        public async Task AggregatingData(CollectedDataType sourceType, CollectedDataType destinationType, 
            TimeSpan interval, bool deleteSource)
        {
            // Subtract interval from the current time
            DateTime timeFrom = DateTime.Now.Add(-interval);
            DateTime timeTo = DateTime.Now;

            var sourceCollectedDataDtos = 
                await _aggregatorService.GetSourceEntitiesAsync(sourceType, timeFrom, timeTo);

            if (sourceCollectedDataDtos != null)
            {
                var collectedDataDtosAverage =
                    from collectedDataDto in sourceCollectedDataDtos
                    group collectedDataDto by collectedDataDto.ClientId
                    into collectedDataGroup
                    select new CollectedDataDto
                    {
                        ClientId = collectedDataGroup.Key,
                        CollectedDataType = destinationType,
                        ProcessesCount = Convert.ToInt32(collectedDataGroup
                            .Average(d => d.ProcessesCount)),
                        CpuUsagePercent = collectedDataGroup
                            .Average(d => d.CpuUsagePercent),
                        RamUsagePercent = collectedDataGroup
                            .Average(d => d.RamUsagePercent),
                        InterruptsTimePercent = collectedDataGroup
                            .Average(d => d.InterruptsTimePercent),
                        LocalDiskFreeSpacePercent = collectedDataGroup
                            .Average(d => d.LocalDiskFreeSpacePercent),
                        AvaliableRamBytes = collectedDataGroup
                            .Average(d => d.AvaliableRamBytes),
                        InterruptsPerSeconds = collectedDataGroup
                            .Average(d => d.InterruptsPerSeconds),
                        LocalDiskFreeMBytes = collectedDataGroup
                            .Average(d => d.LocalDiskFreeMBytes),
                        Time = collectedDataGroup
                            .Max(d => d.Time),
                        ProcessesCPU = collectedDataGroup
                            .SelectMany(d => d.ProcessesCPU)
                            .ToLookup(pair => pair.Key, pair => pair.Value)
                            .ToDictionary(l => l.Key, l => l.Average()),
                        ProcessesRAM = collectedDataGroup
                            .SelectMany(d => d.ProcessesRAM)
                            .ToLookup(pair => pair.Key, pair => pair.Value)
                            .ToDictionary(l => l.Key, l => l.Average()),
                    };

                // Save aggregated CollectedDataDto to destination table MongoDb
                foreach (var collectedDataDto in collectedDataDtosAverage)
                {
                    await _aggregatorService.AddAggregatorEntityAsync(collectedDataDto);
                }


                if (deleteSource)
                {
                    // Delete already aggregated CollectedDataDto from source table MongoDb
                    foreach (var collectedDataDto in sourceCollectedDataDtos)
                    {
                        await _aggregatorService.DeleteAggregatedEntityAsync(collectedDataDto.Id);
                    }
                }
            }
        }
    }
}
