using System;
using System.Collections.Generic;
using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.Shared.Models
{
    public class CollectedDataDto : ICollectedDataDto
    {
        // Id - CollectedData identification number
        public Guid Id { get; set; }
        // ClientId - Client identification number
        public Guid ClientId { get; set; }
        public CollectedDataType CollectedDataType { get; set; }

        public int ProcessesCount { get; set; }
        public Dictionary<string, float> ProcessesCPU { get; set; }
        public Dictionary<string, float> ProcessesRAM { get; set; }
        #region Percentage
        public float CpuUsagePercent { get; set; }
        public float RamUsagePercent { get; set; }
        public float InterruptsTimePercent { get; set; }
        public float LocalDiskFreeSpacePercent { get; set; }
        #endregion
        public float AvaliableRamBytes { get; set; }
        public float InterruptsPerSeconds { get; set; }
        public float LocalDiskFreeMBytes { get; set; }
        public DateTime Time { get; set; }
    }
}
