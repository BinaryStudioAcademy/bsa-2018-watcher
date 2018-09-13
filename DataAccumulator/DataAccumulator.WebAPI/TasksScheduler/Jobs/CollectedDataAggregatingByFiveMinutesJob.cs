namespace DataAccumulator.WebAPI.TasksScheduler.Jobs
{
    using System;
    using System.Threading.Tasks;

    using DataAccumulator.DataAggregator.Interfaces;
    using DataAccumulator.Shared.Models;

    using global::Quartz;

    public class CollectedDataAggregatingByFiveMinutesJob : IJob
    {
        private readonly IDataAggregatorCore<CollectedDataDto> _dataAggregatorCore;

        public CollectedDataAggregatingByFiveMinutesJob(IDataAggregatorCore<CollectedDataDto> dataAggregatorCore)
        {
            _dataAggregatorCore = dataAggregatorCore;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                var sourceType = CollectedDataType.Accumulation;
                var destinationType = CollectedDataType.AggregationForHour;
                var timeSpan = TimeSpan.FromMinutes(5);
                var deleteSource = true;

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
