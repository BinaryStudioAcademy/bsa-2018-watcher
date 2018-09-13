using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator
{
    using System.Diagnostics;

    using DataAccumulator.BusinessLayer.Interfaces;
    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;

    using Microsoft.Extensions.Logging;

    using ServiceBus.Shared.Messages;

    public class DataAggregatorCore : IDataAggregatorCore<CollectedDataDto>
    {
        private readonly IAggregatorService<CollectedDataDto> _aggregatorService;
        private readonly IInstanceAnomalyReportsRepository _reportsRepository;
        private readonly ILogger<DataAggregatorCore> _logger;
        private readonly IAnomalyDetector _anomalyDetector;
        private readonly IServiceBusProvider _serviceBusProvider;

        public DataAggregatorCore(IAggregatorService<CollectedDataDto> aggregatorService,
                                  IInstanceAnomalyReportsRepository reportsRepository,
                                  ILogger<DataAggregatorCore> logger,
                                  IAnomalyDetector anomalyDetector,
                                  IServiceBusProvider provider)
        {
            _aggregatorService = aggregatorService;
            _reportsRepository = reportsRepository;
            _logger = logger;
            _anomalyDetector = anomalyDetector;
            _serviceBusProvider = provider;
        }

        public async Task AggregatingData(CollectedDataType sourceType, CollectedDataType destinationType, TimeSpan interval, bool deleteSource)
        {
            // Need destinationType,
            // Subtract interval from the current time
            var timeFrom = DateTime.UtcNow.Add(-interval);
            var timeTo = DateTime.UtcNow;

            var sourceCollectedDataDtos = (await _aggregatorService.GetSourceEntitiesAsync(sourceType, timeFrom, timeTo)).ToList();
            var filteredCollectedDataDtos = await FilterCollectedDataByInstanceSettings(sourceCollectedDataDtos, destinationType);
            var collectedDataDtos = filteredCollectedDataDtos as CollectedDataDto[] ?? filteredCollectedDataDtos.ToArray();
            if (collectedDataDtos.Any())
            {
                var collectedDataDtosAverage =
                    from collectedDataDto in collectedDataDtos
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

                var tasks = new List<Task> {
                    SendMLReport(collectedDataDtos, destinationType),
                    _aggregatorService.AddAggregatorEntitiesAsync(collectedDataDtosAverage)
                                               };

                // await SendMLReport(collectedDataDtos, destinationType);

                // Save aggregated CollectedDataDto to destination table MongoDb
                // await _aggregatorService.AddAggregatorEntitiesAsync(collectedDataDtosAverage);
                if (deleteSource)
                {
                    // Delete already aggregated CollectedDataDto from source table MongoDb
                    // await _aggregatorService.DeleteManyAggregatedEntitiesAsync(collectedDataDtos.Select(dto => dto.Id));
                    tasks.Add(_aggregatorService.DeleteManyAggregatedEntitiesAsync(collectedDataDtos.Select(dto => dto.Id)));
                }

                await Task.WhenAll(tasks);
            }
        }

        private Task SendMLReport(IEnumerable<CollectedDataDto> data, CollectedDataType reportType)
        {
            var results = (from d in data
                           group d by d.ClientId into g
                           select new { ClientId = g.Key, CollectedDatas = g.ToList() }).ToList();

            var tasks = results.Select(
                async r =>
                    {
                        try
                        {
                            var result = await _anomalyDetector.AnalyzeData(r.CollectedDatas);
                            result.CollectedDataTypeOfReport = reportType;
                            var report = new InstanceAnomalyReport
                            {
                                Id = Guid.NewGuid(),
                                ClientId = r.ClientId,
                                Date = result.Date,
                                AnomalyGroups = result.AnomalyGroups,
                                CollectedDataTypeOfReport = result.CollectedDataTypeOfReport
                            };
                            await _reportsRepository.AddReportAsync(report);
                            var reportMessage =
                                new InstanceAnomalyReportMessage
                                {
                                    AnomalyReportId = report.Id,
                                    InstanceId = r.ClientId
                                };
                            Debug.WriteLine($"Generated id of report {report.Id}");
                            await _serviceBusProvider.SendAnomalyReportMessage(reportMessage);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, $"Unhandled error occurred while analyzing Anomalies of instance with id: {r?.ClientId}");
                            // TODO: Maybe send notification to user about that error that analyzing Anomalies of instance with id was unsuccessful
                        }
                    });

            return Task.WhenAll(tasks);

            //var res = Parallel.ForEach(
            //    results,
            //    async obj =>
            //        {
            //            try
            //            {
            //                var result = await _anomalyDetector.AnalyzeData(obj.CollectedDatas);
            //                result.CollectedDataTypeOfReport = reportType;
            //                var report = new InstanceAnomalyReport
            //                {
            //                    Id = Guid.NewGuid(),
            //                    ClientId = obj.ClientId,
            //                    Date = result.Date,
            //                    AnomalyGroups = result.AnomalyGroups,
            //                    CollectedDataTypeOfReport =
            //                                         result.CollectedDataTypeOfReport
            //                };
            //                await _reportsRepository.AddReportAsync(report);
            //                var reportMessage =
            //                    new InstanceAnomalyReportMessage { AnomalyReportId = report.Id, InstanceId = obj.ClientId };
            //                Debug.WriteLine($"Generated id of report {report.Id}");
            //                await _serviceBusProvider.SendAnomalyReportMessage(reportMessage);
            //            }
            //            catch (Exception ex)
            //            {
            //                _logger.LogError(ex, $"Unhandled error occurred while analyzing Anomalies of instance with id: {obj?.ClientId}");
            //                // TODO: Maybe send notification to user about that error that analyzing Anomalies of instance with id was unsuccessful
            //            }
            //        });
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

    // public class 
}
