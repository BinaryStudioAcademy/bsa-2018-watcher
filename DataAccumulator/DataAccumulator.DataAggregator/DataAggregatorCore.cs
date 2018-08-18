using System;
using System.Threading.Tasks;
using DataAccumulator.DataAggregator.Services;

namespace DataAccumulator.DataAggregator
{
    public class DataAggregatorCore
    {
        private readonly AggregatorService _aggregatorService;

        public DataAggregatorCore(AggregatorService aggregatorService)
        {
            _aggregatorService = aggregatorService;
        }

        public async Task Start()
        {
            // Subtract 1 hour from the current time
            DateTime timeFrom = DateTime.Now.AddHours(-1);
            DateTime timeTo = DateTime.Now;

            var accumulatedData = await _aggregatorService.GetAccumulatorEntitiesAsync(timeFrom, timeTo);

            foreach (var collectedData in accumulatedData)
            {
                await _aggregatorService.AddAggregatorEntityAsync(collectedData);
                await _aggregatorService.DeleteAccumulatorEntityAsync(collectedData.Id);
            }
        }
    }
}
