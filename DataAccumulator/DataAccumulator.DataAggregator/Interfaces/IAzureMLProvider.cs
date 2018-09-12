using DataAccumulator.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccumulator.DataAggregator.Interfaces
{
    public interface IAzureMLProvider
    {
        Task<AzureMLResponse> CheckAnomaly(List<Dictionary<string, string>> input);
    }
}
