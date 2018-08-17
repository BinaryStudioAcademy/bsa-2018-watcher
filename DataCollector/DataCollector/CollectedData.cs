using System;
using System.Collections.Generic;
using System.Text;

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
            foreach (var item in secondItem.ProcessesCPU)
            {
                if (processesCPU.ContainsKey(item.Key))
                    processesCPU[item.Key] += secondItem.ProcessesCPU[item.Key];
                else
                    processesCPU.Add(item.Key, item.Value);
            }

            var processesRAM = firstItem.ProcessesRAM;
            foreach (var item in secondItem.ProcessesCPU)
            {
                if (processesRAM.ContainsKey(item.Key))
                    processesRAM[item.Key] += secondItem.ProcessesRAM[item.Key];
                else
                    processesRAM.Add(item.Key, item.Value);
            }

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

        public static CollectedData operator /(CollectedData item, int scalar)
        {
            var processCPU = new Dictionary<string, float>();
            foreach (var cpu in item.ProcessesCPU)
            {
                processCPU.Add(cpu.Key, cpu.Value / (float)scalar);
            }

            var processRAM = new Dictionary<string, float>();
            foreach (var ram in item.ProcessesRAM)
            {
                processRAM.Add(ram.Key, ram.Value / (float)scalar);
            }

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
            str.Append($"Processes count: {this.ProcessesCount}\n");
            str.Append($"CPU usage: {this.CpuUsagePercent}%\n");
            str.Append($"Ram avalaible: {this.AvaliableRamBytes} bytes\n");
            str.Append($"Ram usage: {this.RamUsagePercent}%\n");
            str.Append($"Local dist avalaible: {this.LocalDiskFreeMBytes} MB\n");
            return str.ToString();
        }
    }
}
