using System;
using System.Collections.Generic;
using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.Shared.Models
{
    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public class CollectedDataDto : ICollectedDataDto
    {
        // Id to reference
        public Guid Id { get; set; }
        // ClientId - Client identification number
        public Guid ClientId { get; set; }

        public CollectedDataType CollectedDataType { get; set; }

        public int ProcessesCount { get; set; }
        public List<ProcessData> Processes { get; set; }

        public float UsageRamMBytes { get; set; }
        public float TotalRamMBytes { get; set; }
        public float RamUsagePercentage { get; set; }

        public float InterruptsPerSeconds { get; set; }

        public float LocalDiskUsageMBytes { get; set; }
        public float LocalDiskTotalMBytes { get; set; }
        public float LocalDiskUsagePercentage { get; set; }

        public float CpuUsagePercentage { get; set; }

        public DateTime Time { get; set; }
    }
}
