using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccumulator.DataAggregator;
using DataAccumulator.DataAggregator.Services;
using Quartz;

namespace DataAccumulator.WebAPI.Jobs
{
    public class CollectedDataAggregatingJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                //await _dataAggregatorCore.AggregatingData();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
