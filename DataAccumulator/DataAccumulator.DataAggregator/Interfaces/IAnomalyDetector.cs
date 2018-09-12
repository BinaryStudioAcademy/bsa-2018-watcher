using System.Collections.Generic;
using System.Threading.Tasks;

using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator.Interfaces
{
    public interface IAnomalyDetector
    {
        Task<AzureMLAnomalyReport> AnalyzeData(IEnumerable<CollectedDataDto> collectedData);
    }
}
