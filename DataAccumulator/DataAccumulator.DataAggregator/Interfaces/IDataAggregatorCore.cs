using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.DataAggregator.Interfaces
{
    public interface IDataAggregatorCore<TEntity> where TEntity : ICollectedDataDto
    {
        Task AggregatingData();
        Task AggregatingData(TimeSpan interval);
    }
}
