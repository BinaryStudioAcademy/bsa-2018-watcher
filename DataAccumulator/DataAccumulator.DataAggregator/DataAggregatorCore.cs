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
                        CpuUsagePercentage = collectedDataGroup
                            .Average(d => d.CpuUsagePercentage),
                        FreeRamMBytes = collectedDataGroup
                            .Average(d => d.FreeRamMBytes),
                        TotalRamMBytes = collectedDataGroup
                            .Average(d => d.TotalRamMBytes),
                        FreeRamPercentage = collectedDataGroup
                            .Average(d => d.FreeRamPercentage),
                        InterruptsPerSeconds = collectedDataGroup
                            .Average(d => d.InterruptsPerSeconds),
                        LocalDiskFreeMBytes = collectedDataGroup
                            .Average(d => d.LocalDiskFreeMBytes),
                        LocalDiskTotalMBytes = collectedDataGroup
                            .Average(d => d.LocalDiskTotalMBytes),
                        LocalDiskFreePercentage = collectedDataGroup
                            .Average(d => d.LocalDiskFreePercentage),
                        Time = collectedDataGroup
                            .Max(d => d.Time),
                        //Processes = collectedDataGroup.SelectMany(d => d.Processes).ToList()
                        //    .SelectMany(d => d.Processes)
                        //    .ToLookup(pair => pair.Key, pair => pair.Value)
                        //    .ToDictionary(l => l.Key, l => l.Average()),
                        //Processes = collectedDataGroup.SelectMany(d => d.Processes).GroupBy(p => p.Name).SelectMany(g => g.Key.)
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
