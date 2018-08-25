using System;
using Watcher.Common.Interfaces.Entities;

namespace Watcher.Common.Dtos.Plots
{
    public class PercentageInfo : ICollectedData
    {
        public PercentageInfo() { }
        
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public DateTime Time { get; set; }

        public float CpuUsagePercent { get; set; }
        public float RamUsagePercent { get; set; }
        public float InterruptsTimePercent { get; set; }
        public float LocalDiskFreeSpacePercent { get; set; }
    }
}
