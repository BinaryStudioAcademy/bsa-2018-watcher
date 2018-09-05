namespace DataAccumulator.Shared.Models
{
    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public enum CollectedDataType
    {
        Accumulation,
        AggregationForHour,
        AggregationForDay,
        AggregationForWeek,
        AggregationForMonth
    }
}
