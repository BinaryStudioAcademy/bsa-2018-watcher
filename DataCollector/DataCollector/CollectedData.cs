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
            Processes = new List<ProcessData>();
        }

        // Id to reference
        public Guid Id { get; set; }
        // ClientId - Client identification number
        public Guid ClientId { get; set; }

        public int ProcessesCount { get; set; }
        public List<ProcessData> Processes { get; set; }
        public float FreeRamMBytes { get; set; }
        public float TotalRamMBytes { get; set; }
        public float FreeRamPercentage { get; set; }
        public float InterruptsPerSeconds { get; set; }
        public float LocalDiskFreeMBytes { get; set; }
        public float LocalDiskTotalMBytes { get; set; }
        public float LocalDiskFreePercentage { get; set; }
        public DateTime Time { get; set; }


        public static CollectedData operator +(CollectedData firstItem, CollectedData secondItem)
        {
            var processes = firstItem.Processes;

            //secondItem.Processes
            //    .ForEach(item => ConcatProcessInfo(processes, item));


            return new CollectedData
            {
                //AvaliableRamBytes = firstItem.AvaliableRamBytes + secondItem.AvaliableRamBytes,
                CpuUsagePercent = firstItem.CpuUsagePercent + secondItem.CpuUsagePercent,
                InterruptsPerSeconds = firstItem.InterruptsPerSeconds + secondItem.InterruptsPerSeconds,
                InterruptsTimePercent = firstItem.InterruptsTimePercent + secondItem.InterruptsTimePercent,
                LocalDiskFreeMBytes = firstItem.LocalDiskFreeMBytes + secondItem.LocalDiskFreeMBytes,
                LocalDiskFreeSpacePercent = firstItem.LocalDiskFreeSpacePercent + secondItem.LocalDiskFreeSpacePercent,
                RamUsagePercent = firstItem.RamUsagePercent + secondItem.RamUsagePercent,
                Time = secondItem.Time,
                Processes = processes,
                
                ProcessesCount = processes.Count
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
            var process = new List<ProcessData>();

            //item.ProcessesCpu.ToList()
            //    .ForEach(cpu => processCpu.Add(cpu.Key, cpu.Value / scalar));

            //item.ProcessesRam.ToList()
            //    .ForEach(ram => processRam.Add(ram.Key, ram.Value / scalar));

            return new CollectedData
            {
                //AvaliableRamBytes = item.AvaliableRamBytes / scalar,
                CpuUsagePercent = item.CpuUsagePercent / scalar,
                InterruptsPerSeconds = item.InterruptsPerSeconds / scalar,
                InterruptsTimePercent = item.InterruptsTimePercent / scalar,
                LocalDiskFreeMBytes = item.LocalDiskFreeMBytes / scalar,
                LocalDiskFreeSpacePercent = item.LocalDiskFreeSpacePercent / scalar,
                ProcessesCount = item.ProcessesCount,
                RamUsagePercent = item.RamUsagePercent / scalar,
                Time = item.Time,
                Processes = process
            };
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.Append($"Instance id: {ClientId}\n");
            str.Append($"Processes count: {ProcessesCount}\n");
            str.Append($"CPU usage: {CpuUsagePercent:0.##}%\n");
            //str.Append($"Ram avalaible: {AvaliableRamMBytes:0.##} MB\n");
            str.Append($"Ram usage: {RamUsagePercent:0.##}%\n");
            str.Append($"Local disk avalaible: {LocalDiskFreeMBytes:0.##} MB\n");
            return str.ToString();
        }

        #region Percentage

        public float CpuUsagePercent { get; set; }
        public float RamUsagePercent { get; set; }
        public float InterruptsTimePercent { get; set; }
        public float LocalDiskFreeSpacePercent { get; set; }

        #endregion
    }

    public class ProcessData
    {
        public string Name { get; set; }
        public float RamMBytes { get; set; }
        public float PRam { get; set; }
        public float PCpu { get; set; }
    }
}