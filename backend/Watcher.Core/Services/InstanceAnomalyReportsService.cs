namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;
    using DataAccumulator.Shared.Models;

    using Watcher.Core.Interfaces;

    public class InstanceAnomalyReportsService : IInstanceAnomalyReportsService
    {
        private readonly IInstanceAnomalyReportsRepository _repository;

        public InstanceAnomalyReportsService(IInstanceAnomalyReportsRepository repository)
        {
            _repository = repository;
        }

        public static InstanceAnomalyReport GetAnomalyReport(Guid instanceId)
        {
            var parameters = new List<string> { "CPU", "RAM", "DISC" };
            var random = new Random();
            var groups = new List<AzureMLAnomalyGroup>(3);
            var dateTime = DateTime.UtcNow;

            var processes = parameters.Count;
            for (var i = 0; i < processes; i++)
            {
                var warningsCount = random.Next(10, 29);
                groups.Add(new AzureMLAnomalyGroup()
                {
                    Name = parameters[i],
                    Warnings = new List<AzureMLAnomaly>(warningsCount),
                    Anomalies = new List<AzureMLAnomaly>((warningsCount / 2) + 1),
                    Total = random.Next(10, 50)
                });
            }

            foreach (var g in groups)
            {
                for (var i = 0; i < g.Warnings.Capacity; i++)
                {
                    var anomaly = new AzureMLAnomaly
                    {
                        Time = dateTime.AddMinutes(i * 2),
                        Data = random.Next(50, 100)
                    };
                    g.Warnings.Add(anomaly);
                    if (i % 2 == 0)
                    {
                        g.Anomalies.Add(anomaly);
                    }
                }
            }

            var report = new InstanceAnomalyReport
                        {
                            Id = Guid.NewGuid(),
                            Date = DateTime.UtcNow.AddHours(1),
                            ClientId = Guid.NewGuid(),
                            AnomalyGroups = groups,
                            CollectedDataTypeOfReport = CollectedDataType.AggregationForHour
                        };
            
            return report;
        }
    }
}
