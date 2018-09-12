using DataAccumulator.BusinessLayer.Services;
using DataAccumulator.DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccumulator.BusinessLayer.Interfaces
{
    public interface IAnomalyDetector
    {
        Task<AzureMLAnomalyReport> AnalyzeData(IEnumerable<CollectedData> collectedData);
    }
}
