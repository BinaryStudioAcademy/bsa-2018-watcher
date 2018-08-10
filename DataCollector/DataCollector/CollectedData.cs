using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollector
{
    [Serializable]
    public class CollectedData
    {
        public int ProcessesCount { get; set; }
        public Dictionary<string,float> ProcessesCPU { get; set; }
        public Dictionary<string,float> ProcessesRAM { get; set; }
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
