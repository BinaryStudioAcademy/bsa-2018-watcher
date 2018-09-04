namespace Watcher.Common.Requests
{
    using System;
    using DataAccumulator.Shared.Models;

    public class AggregateDataRequest
    {
        public string Id { get; set; }
        public int Type { get; set; }
        //public DateTime From { get; set; }
        //public DateTime To { get; set; }
    }
}
