using System;
using System.Threading.Tasks;
using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.Shared.Models;
using Quartz;

namespace DataAccumulator.WebAPI.TasksScheduler.Jobs
{
    public class CollectedDataAggregatingByMonthJob : IJob
    {
        private readonly IDataAggregatorCore<CollectedDataDto> _dataAggregatorCore;
        public CollectedDataAggregatingByMonthJob(IDataAggregatorCore<CollectedDataDto> dataAggregatorCore)
        {
            _dataAggregatorCore = dataAggregatorCore;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                var sourceType = CollectedDataType.AggregationForWeek;
                var destinationType = CollectedDataType.AggregationForMonth;
                var timeSpan = TimeSpan.FromDays(31);
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
