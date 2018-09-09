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
                        Processes = collectedDataGroup
                            .SelectMany(d => d.Processes)
                            .GroupBy(p => p.Name)
                            .Select(g => new ProcessData()
                            {
                                Name = g.Key,
                                PCpu = g.Average(c => c.PCpu),
                                PCpuMax = g.Max(c => c.PCpu),
                                PCpuMin = g.Min(c => c.PCpu),

                                PRam = g.Average(r => r.PRam),
                                PRamMax = g.Max(r => r.PRam),
                                PRmaMin = g.Min(r => r.PRam),

                                RamMBytes = g.Average(b => b.RamMBytes),
                                RamMBytesMax = g.Max(b => b.RamMBytes),
                                RamMBytesMin = g.Min(b => b.RamMBytes)
                            }).ToList(),

                        UsageRamMBytes = collectedDataGroup
                            .Average(d => d.UsageRamMBytes),
                        TotalRamMBytes = collectedDataGroup
                            .Average(d => d.TotalRamMBytes),
                        RamUsagePercentage = collectedDataGroup
                            .Average(d => d.RamUsagePercentage),

                        InterruptsPerSeconds = collectedDataGroup
                            .Average(d => d.InterruptsPerSeconds),

                        LocalDiskUsageMBytes = collectedDataGroup
                            .Average(d => d.LocalDiskUsageMBytes),
                        LocalDiskTotalMBytes = collectedDataGroup
                            .Average(d => d.LocalDiskTotalMBytes),
                        LocalDiskUsagePercentage = collectedDataGroup
                            .Average(d => d.LocalDiskUsagePercentage),

                        CpuUsagePercentage = collectedDataGroup
                            .Average(d => d.CpuUsagePercentage),

                        Time = collectedDataGroup
                            .Max(d => d.Time)
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
