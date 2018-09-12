using ServiceBus.Shared.ML;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccumulator.BusinessLayer.Interfaces
{
    public interface IAzureMLProvider
    {
        Task<AzureMLResponse> CheckAnomaly(List<Dictionary<string, string>> input);
    }
}
