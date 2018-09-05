using System;
using System.Collections.Generic;
using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.Shared.Models
{
    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public class CollectedDataDto : ICollectedDataDto
    {
        // Id - CollectedData identification number
        public Guid Id { get; set; }
        // ClientId - Client identification number
        public Guid ClientId { get; set; }
        public CollectedDataType CollectedDataType { get; set; }

        public int ProcessesCount { get; set; }
        public List<ProcessData> Processes { get; set; }
        public float CpuUsagePercentage { get; set; }

        public float FreeRamMBytes { get; set; }
        public float TotalRamMBytes { get; set; }
        public float FreeRamPercentage { get; set; }
        public float InterruptsPerSeconds { get; set; }
        public float LocalDiskFreeMBytes { get; set; }
        public float LocalDiskTotalMBytes { get; set; }
        public float LocalDiskFreePercentage { get; set; }
        public DateTime Time { get; set; }
    }
}
