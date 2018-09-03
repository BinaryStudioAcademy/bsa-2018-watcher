using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataCollector
{
    [Serializable]
    public class CollectedData
    {
        public CollectedData()
        {
            ProcessesCpu = new Dictionary<string, float>();
            ProcessesRam = new Dictionary<string, float>();
        }

        // Id to reference
        public Guid Id { get; set; }
        // ClientId - Client identification number
        public Guid ClientId { get; set; }

        public int ProcessesCount { get; set; }
        public Dictionary<string, float> ProcessesCpu { get; set; }
        public Dictionary<string, float> ProcessesRam { get; set; }
        public float AvaliableRamBytes { get; set; }
        public float InterruptsPerSeconds { get; set; }
        public float LocalDiskFreeMBytes { get; set; }
        public DateTime Time { get; set; }


        public static CollectedData operator +(CollectedData firstItem, CollectedData secondItem)
        {
            var processesCpu = firstItem.ProcessesCpu;

            secondItem.ProcessesCpu.ToList()
                .ForEach(item => ConcatProcessInfo(processesCpu, item));

            var processesRam = firstItem.ProcessesRam;

            secondItem.ProcessesRam.ToList()
                .ForEach(item => ConcatProcessInfo(processesRam, item));

            return new CollectedData
            {
                AvaliableRamBytes = firstItem.AvaliableRamBytes + secondItem.AvaliableRamBytes,
                CpuUsagePercent = firstItem.CpuUsagePercent + secondItem.CpuUsagePercent,
                InterruptsPerSeconds = firstItem.InterruptsPerSeconds + secondItem.InterruptsPerSeconds,
                InterruptsTimePercent = firstItem.InterruptsTimePercent + secondItem.InterruptsTimePercent,
                LocalDiskFreeMBytes = firstItem.LocalDiskFreeMBytes + secondItem.LocalDiskFreeMBytes,
                LocalDiskFreeSpacePercent = firstItem.LocalDiskFreeSpacePercent + secondItem.LocalDiskFreeSpacePercent,
                RamUsagePercent = firstItem.RamUsagePercent + secondItem.RamUsagePercent,
                Time = secondItem.Time,
                ProcessesCpu = processesCpu,
                ProcessesRam = processesRam,
                ProcessesCount = processesCpu.Count
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
            var processCpu = new Dictionary<string, float>();
            var processRam = new Dictionary<string, float>();

            item.ProcessesCpu.ToList()
                .ForEach(cpu => processCpu.Add(cpu.Key, cpu.Value / scalar));

            item.ProcessesRam.ToList()
                .ForEach(ram => processRam.Add(ram.Key, ram.Value / scalar));

            return new CollectedData
            {
                AvaliableRamBytes = item.AvaliableRamBytes / scalar,
                CpuUsagePercent = item.CpuUsagePercent / scalar,
                InterruptsPerSeconds = item.InterruptsPerSeconds / scalar,
                InterruptsTimePercent = item.InterruptsTimePercent / scalar,
                LocalDiskFreeMBytes = item.LocalDiskFreeMBytes / scalar,
                LocalDiskFreeSpacePercent = item.LocalDiskFreeSpacePercent / scalar,
                ProcessesCount = item.ProcessesCount,
                RamUsagePercent = item.RamUsagePercent / scalar,
                Time = item.Time,
                ProcessesCpu = processCpu,
                ProcessesRam = processRam
            };
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.Append($"Instance id: {ClientId}\n");
            str.Append($"Processes count: {ProcessesCount}\n");
            str.Append($"CPU usage: {CpuUsagePercent:.##}%\n");
            str.Append($"Ram avalaible: {AvaliableRamBytes:.##} MB\n");
            str.Append($"Ram usage: {RamUsagePercent:.##}%\n");
            str.Append($"Local disk avalaible: {LocalDiskFreeMBytes:.##} MB\n");
            return str.ToString();
        }

        #region Percentage

        public float CpuUsagePercent { get; set; }
        public float RamUsagePercent { get; set; }
        public float InterruptsTimePercent { get; set; }
        public float LocalDiskFreeSpacePercent { get; set; }

        #endregion
    }
}