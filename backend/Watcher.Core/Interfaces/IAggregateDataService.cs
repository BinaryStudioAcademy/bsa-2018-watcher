namespace Watcher.Core.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DataAccumulator.Shared.Models;

    public interface IAggregateDataService
    {
        Task<IEnumerable<CollectedDataDto>> GetAggregatedDataInTime(Guid id, CollectedDataType collectedDataType,
            DateTime timeFrom, DateTime timeTo, int page = 1, int count = 10);
    }
}
