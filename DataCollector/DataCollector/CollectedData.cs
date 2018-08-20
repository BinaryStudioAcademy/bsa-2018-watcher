using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataCollector
{
    [Serializable]
    public class CollectedData
    {
        public CollectedData()
        {
            ProcessesCPU = new Dictionary<string, float>();
            ProcessesRAM = new Dictionary<string, float>();
        }

        public Guid Id { get; set; }
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


        public static CollectedData operator +(CollectedData firstItem, CollectedData secondItem)
        {
            var processesCPU = firstItem.ProcessesCPU;

            secondItem.ProcessesCPU.ToList()
                .ForEach(item => ConcatProcessInfo(processesCPU, item));

            var processesRAM = firstItem.ProcessesRAM;

            secondItem.ProcessesRAM.ToList()
                .ForEach(item => ConcatProcessInfo(processesRAM, item));

            return new CollectedData()
            {
                AvaliableRamBytes = firstItem.AvaliableRamBytes + secondItem.AvaliableRamBytes,
                CpuUsagePercent = firstItem.CpuUsagePercent + secondItem.CpuUsagePercent,
                InterruptsPerSeconds = firstItem.InterruptsPerSeconds + secondItem.InterruptsPerSeconds,
                InterruptsTimePercent = firstItem.InterruptsTimePercent + secondItem.InterruptsTimePercent,
                LocalDiskFreeMBytes = firstItem.LocalDiskFreeMBytes + secondItem.LocalDiskFreeMBytes,
                LocalDiskFreeSpacePercent = firstItem.LocalDiskFreeSpacePercent + secondItem.LocalDiskFreeSpacePercent,
                RamUsagePercent = firstItem.RamUsagePercent + secondItem.RamUsagePercent,
                Time = secondItem.Time,
                ProcessesCPU = processesCPU,
                ProcessesRAM = processesRAM,
                ProcessesCount = processesCPU.Count
            };
        }

        public static void ConcatProcessInfo(
            Dictionary<string, float> processInfo,
            KeyValuePair<string, float> item)
        {
            if (processInfo.ContainsKey(item.Key))
                processInfo[item.Key] += item.Value;
            else
                processInfo.Add(item.Key, item.Value);
        }

        public static CollectedData operator /(CollectedData item, int scalar)
        {
            var processCPU = new Dictionary<string, float>();
            var processRAM = new Dictionary<string, float>();

            item.ProcessesCPU.ToList()
                .ForEach(cpu => processCPU.Add(cpu.Key, cpu.Value / scalar));

            item.ProcessesRAM.ToList()
                .ForEach(ram => processRAM.Add(ram.Key, ram.Value / scalar));

            return new CollectedData()
            {
                AvaliableRamBytes = item.AvaliableRamBytes / (float)scalar,
                CpuUsagePercent = item.CpuUsagePercent / (float)scalar,
                InterruptsPerSeconds = item.InterruptsPerSeconds / (float)scalar,
                InterruptsTimePercent = item.InterruptsTimePercent / (float)scalar,
                LocalDiskFreeMBytes = item.LocalDiskFreeMBytes / (float)scalar,
                LocalDiskFreeSpacePercent = item.LocalDiskFreeSpacePercent / (float)scalar,
                ProcessesCount = item.ProcessesCount,
                RamUsagePercent = item.RamUsagePercent / (float)scalar,
                Time = item.Time,
                ProcessesCPU = processCPU,
                ProcessesRAM = processRAM
            };
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Instance id: {this.Id}\n");
            str.Append($"Processes count: {this.ProcessesCount}\n");
            str.Append($"CPU usage: {this.CpuUsagePercent}%\n");
            str.Append($"Ram avalaible: {this.AvaliableRamBytes} bytes\n");
            str.Append($"Ram usage: {this.RamUsagePercent}%\n");
            str.Append($"Local disk avalaible: {this.LocalDiskFreeMBytes} MB\n");
            return str.ToString();
        }
    }
}
