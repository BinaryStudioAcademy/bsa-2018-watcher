using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccumulator.DataAggregator.Interfaces
{
    public interface IAnomalyDetector
    {
        Task<AzureMLAnomalyReport> AnalyzeData(IEnumerable<CollectedDataDto> collectedData);
    }
}
