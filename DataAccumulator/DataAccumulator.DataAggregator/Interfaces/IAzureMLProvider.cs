using System.Collections.Generic;
using System.Threading.Tasks;

using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator.Interfaces
{
    public interface IAzureMLProvider
    {
        Task<AzureMLResponse> CheckAnomaly(List<Dictionary<string, string>> input);
    }
}
