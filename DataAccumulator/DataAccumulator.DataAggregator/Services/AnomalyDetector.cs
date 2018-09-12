using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator.Services
{
    public class AnomalyDetector : IAnomalyDetector
    {
        private readonly IAzureMLProvider _azureMLProvider;

        public AnomalyDetector(IAzureMLProvider azureMLProvider)
        {
            _azureMLProvider = azureMLProvider;
        }

        public async Task<AzureMLAnomalyReport> AnalyzeData(IEnumerable<CollectedDataDto> collectedData)
        {
            var data = new[]
            {
                MapInput(collectedData, x => x.CpuUsagePercentage),
                MapInput(collectedData, x => x.RamUsagePercentage),
                MapInput(collectedData, x => x.LocalDiskUsagePercentage)
            };
            var results = await Task.WhenAll(data.Select(_azureMLProvider.CheckAnomaly));

            return BuildReport(results);
        }

        private List<Dictionary<string, string>> MapInput<T>(IEnumerable<CollectedDataDto> data, Func<CollectedDataDto, T> selector)
        {
            return data.Select(x => new Dictionary<string, string>
            {
                { "Data", selector(x).ToString() },
                { "Time", x.Time.ToString("MM/dd/yyyy hh:mm:ss.fff tt") }
            }).ToList();
        }

        private AzureMLAnomalyReport BuildReport(AzureMLResponse[] reponses)
        {
            return new AzureMLAnomalyReport
            {
                Date = DateTime.UtcNow,
                AnomalyGroups = new List<AzureMLAnomalyGroup>
                {
                    GetAnomalyGroup("CPU", reponses[0]?.Results?.Output),
                    GetAnomalyGroup("RAM", reponses[1]?.Results?.Output),
                    GetAnomalyGroup("DISK", reponses[2]?.Results?.Output),
                }
            };
        }

        private AzureMLAnomalyGroup GetAnomalyGroup(string name, List<AzureMLOutput> outputs)
            => new AzureMLAnomalyGroup
            {
                Name = name,
                Total = outputs.Count,
                Warnings = GetAnomalies(outputs, x => x.ZSpike && !x.TSpike),
                Anomalies = GetAnomalies(outputs, x => x.ZSpike && x.TSpike),
            };

        private List<AzureMLAnomaly> GetAnomalies(List<AzureMLOutput> collection, Func<AzureMLOutput, bool> predicate)
            => collection.Where(predicate).Select(x => new AzureMLAnomaly { Time = x.Time, Data = x.Data }).ToList();

    }
}
