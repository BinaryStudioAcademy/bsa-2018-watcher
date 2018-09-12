using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator
{
    public class DataAggregatorCore : IDataAggregatorCore<CollectedDataDto>
    {
        private readonly IAggregatorService<CollectedDataDto> _aggregatorService;
        private readonly IAnomalyDetector _anomalyDetector;

        public DataAggregatorCore(IAggregatorService<CollectedDataDto> aggregatorService, IAnomalyDetector anomalyDetector)
        {
            _aggregatorService = aggregatorService;
            _anomalyDetector = anomalyDetector;
        }

        public async Task AggregatingData(CollectedDataType sourceType, CollectedDataType destinationType, 
            TimeSpan interval, bool deleteSource)
        {
            // Subtract interval from the current time
            DateTime timeFrom = DateTime.Now.Add(-interval);
            DateTime timeTo = DateTime.Now;

            var sourceCollectedDataDtos = await _aggregatorService.GetSourceEntitiesAsync(sourceType, timeFrom, timeTo);
            var listCollectedDataDtos = sourceCollectedDataDtos.ToList();
            var filteredCollectedDataDtos =
                await FilterCollectedDataByInstanceSettings(listCollectedDataDtos, destinationType);
                

            if (filteredCollectedDataDtos != null)
            {
                await SendMLReport(filteredCollectedDataDtos);

                var collectedDataDtosAverage =
                    from collectedDataDto in filteredCollectedDataDtos
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
                                PRamMin = g.Min(r => r.PRam),

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
                    foreach (var collectedDataDto in filteredCollectedDataDtos)
                    {
                        await _aggregatorService.DeleteAggregatedEntityAsync(collectedDataDto.Id);
                    }
                }
            }
        }

        private async Task SendMLReport(IEnumerable<CollectedDataDto> data)
        {
            try
            {
                var result = await _anomalyDetector.AnalyzeData(data);
                // WebServer - DataAccumulator
                // TODO: Create new notification model 
                // Notification { Type => Hourly|Weekly|Dayly, Report => AzureMLReport }  
                // TODO: Save report in MongoDB
                // WebServer - Watcher
                // TODO: Send notification to Angular
                // TODO: Send email to user
            }
            catch (Exception)
            {
                // TODO: handle exception
            }
        }

        private async Task<IEnumerable<CollectedDataDto>> FilterCollectedDataByInstanceSettings(List<CollectedDataDto> collectedDataDtos, 
            CollectedDataType destinationType)
        {
            var instanceSettingsDtos = await _aggregatorService.GetInstanceSettingsEntitiesAsync();
            List<InstanceSettingsDto> instanceSettingsList = instanceSettingsDtos.ToList();
            List<CollectedDataDto> filteredCollectedDataDtos = new List<CollectedDataDto>();

            switch (destinationType)
            {
                case CollectedDataType.AggregationForHour:
                {
                    instanceSettingsList.ForEach(instanceSettings =>
                    {
                        if (instanceSettings.IsActive && instanceSettings.AggregationForHour)
                        {
                            var data = collectedDataDtos.Where(d => d.ClientId == instanceSettings.ClientId).ToList();
                            filteredCollectedDataDtos.AddRange(data);
                        }
                    });

                    break;
                }

                case CollectedDataType.AggregationForDay:
                {
                    instanceSettingsList.ForEach(instanceSettings =>
                    {
                        if (instanceSettings.IsActive && instanceSettings.AggregationForDay)
                        {
                            var data = collectedDataDtos.Where(d => d.ClientId == instanceSettings.ClientId).ToList();
                            filteredCollectedDataDtos.AddRange(data);
                        }
                    });

                    break;
                }

                case CollectedDataType.AggregationForWeek:
                {
                    instanceSettingsList.ForEach(instanceSettings =>
                    {
                        if (instanceSettings.IsActive && instanceSettings.AggregationForWeek)
                        {
                            var data = collectedDataDtos.Where(d => d.ClientId == instanceSettings.ClientId).ToList();
                            filteredCollectedDataDtos.AddRange(data);
                        }
                    });

                    break;
                }

                case CollectedDataType.AggregationForMonth:
                {
                    instanceSettingsList.ForEach(instanceSettings =>
                    {
                        if (instanceSettings.IsActive && instanceSettings.AggregationForMonth)
                        {
                            var data = collectedDataDtos.Where(d => d.ClientId == instanceSettings.ClientId).ToList();
                            filteredCollectedDataDtos.AddRange(data);
                        }
                    });

                    break;
                }
            }

            return filteredCollectedDataDtos;
        }
    }
}
