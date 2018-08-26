using System;
using System.Collections.Generic;
using Watcher.Common.Interfaces.Entities;

namespace Watcher.Common.Dtos.Plots
{
    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public class CollectedDataDto : ICollectedData
    {
        // Id - CollectedData identification number
        public Guid Id { get; set; }
        // ClientId - Client identification number
        public Guid ClientId { get; set; }

        public DateTime Time { get; set; }
        public int ProcessesCount { get; set; }
        public Dictionary<string, float> ProcessesCPU { get; set; }
        public Dictionary<string, float> ProcessesRAM { get; set; }

        public float CpuUsagePercent { get; set; }
        public float RamUsagePercent { get; set; }
        public float InterruptsTimePercent { get; set; }
        public float LocalDiskFreeSpacePercent { get; set; }

        public float AvaliableRamBytes { get; set; }
        public float InterruptsPerSeconds { get; set; }
        public float LocalDiskFreeMBytes { get; set; }
    }
}
