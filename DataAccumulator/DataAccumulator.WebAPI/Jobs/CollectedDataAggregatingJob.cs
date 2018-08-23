using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccumulator.DataAggregator;
using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.DataAggregator.Services;
using DataAccumulator.Shared.Models;
using Quartz;

namespace DataAccumulator.WebAPI.Jobs
{
    public class CollectedDataAggregatingJob : IJob
    {
        private readonly IDataAggregatorCore<CollectedDataDto> _dataAggregatorCore;
        public CollectedDataAggregatingJob(IDataAggregatorCore<CollectedDataDto> dataAggregatorCore)
        {
            _dataAggregatorCore = dataAggregatorCore;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                // Run Aggregating CollectedData
                await _dataAggregatorCore.AggregatingData();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
