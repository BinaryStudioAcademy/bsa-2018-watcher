using System;
using Watcher.Common.Interfaces.Entities;

namespace Watcher.Common.Dtos.Plots
{
    public class MemoryInfo : ICollectedData
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }

        public float AvaliableRamBytes { get; set; }
        public float InterruptsPerSeconds { get; set; }
        public float LocalDiskFreeMBytes { get; set; }
    }
}
