using System;
using Watcher.Common.Interfaces.Entities;

namespace Watcher.Common.Dtos.PlotsDtos
{
    public class PercentageInfo: ICollectedData
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }

        public float CpuUsagePercent { get; set; }
        public float RamUsagePercent { get; set; }
        public float InterruptsTimePercent { get; set; }
        public float LocalDiskFreeSpacePercent { get; set; }
    }
}
