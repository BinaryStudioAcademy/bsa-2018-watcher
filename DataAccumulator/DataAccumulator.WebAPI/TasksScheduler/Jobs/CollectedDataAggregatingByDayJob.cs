using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.Shared.Models;
using Quartz;

namespace DataAccumulator.WebAPI.TasksScheduler.Jobs
{
    public class CollectedDataAggregatingByDayJob : IJob
    {
        private readonly IDataAggregatorCore<CollectedDataDto> _dataAggregatorCore;
        public CollectedDataAggregatingByDayJob(IDataAggregatorCore<CollectedDataDto> dataAggregatorCore)
        {
            _dataAggregatorCore = dataAggregatorCore;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                var sourceType = CollectedDataType.AggregationForHour;
                var destinationType = CollectedDataType.AggregationForDay;
                var timeSpan = TimeSpan.FromDays(1);
                var deleteSource = false;

                // Run Aggregating CollectedData
                await _dataAggregatorCore.AggregatingData(sourceType, destinationType, timeSpan, deleteSource);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
