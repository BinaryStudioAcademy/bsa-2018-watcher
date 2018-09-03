using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccumulator.Shared.Interfaces;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator.Interfaces
{
    public interface IDataAggregatorCore<TEntity> where TEntity : ICollectedDataDto
    {
        Task AggregatingData(CollectedDataType sourceType, CollectedDataType destinationType, 
            TimeSpan interval, bool deleteSource);
    }
}
