using System;

using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.Shared.Models
{
    public class InstanceSettingsDto : ICollectedDataDto
    {
        // Id - InstanceValidator identification number
        public Guid Id { get; set; }
        // ClientId - Instance identification number
        public Guid ClientId { get; set; }
        public bool IsActive { get; set; }

        public bool AggregationForHour { get; set; }
        public bool AggregationForDay { get; set; }
        public bool AggregationForWeek { get; set; }
        public bool AggregationForMonth { get; set; }

        public bool RamValidator { get; set; }
        public float RamUsagePercentageMax { get; set; }

        public bool LocalDiskVallidator { get; set; }
        public float LocalDiskUsagePercentageMax { get; set; }

        public bool CpuValidator { get; set; }
        public float CpuUsagePercentageMax { get; set; }
    }
}
