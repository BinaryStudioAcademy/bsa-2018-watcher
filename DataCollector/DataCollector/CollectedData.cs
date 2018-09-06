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

        public float InterruptsTimePercent { get; set; }
        public float InterruptsPerSeconds { get; set; }

        public int ProcessesCount { get; set; }
        public List<ProcessData> Processes { get; set; }

        public float UsageRamMBytes { get; set; }
        public float TotalRamMBytes { get; set; }
        public float RamUsagePercentage { get; set; }


        public float LocalDiskUsageMBytes { get; set; }
        public float LocalDiskTotalMBytes { get; set; }
        public float LocalDiskUsagePercentage { get; set; }

        public float CpuUsagePercentage { get; set; }

        public DateTime Time { get; set; }


        public static CollectedData operator +(CollectedData firstItem, CollectedData secondItem)
        {
            return new CollectedData
            {
                
                InterruptsTimePercent = firstItem.InterruptsTimePercent + secondItem.InterruptsTimePercent,
                InterruptsPerSeconds = firstItem.InterruptsPerSeconds + secondItem.InterruptsPerSeconds,

                ProcessesCount = secondItem.ProcessesCount,

                UsageRamMBytes = firstItem.UsageRamMBytes + secondItem.UsageRamMBytes,
                TotalRamMBytes = firstItem.TotalRamMBytes + secondItem.TotalRamMBytes,
                RamUsagePercentage = firstItem.RamUsagePercentage + secondItem.RamUsagePercentage,

                LocalDiskUsageMBytes = firstItem.LocalDiskUsageMBytes + secondItem.LocalDiskUsageMBytes,
                LocalDiskTotalMBytes = firstItem.LocalDiskTotalMBytes + secondItem.LocalDiskTotalMBytes,
                LocalDiskUsagePercentage = firstItem.LocalDiskUsagePercentage + secondItem.LocalDiskUsagePercentage,

                CpuUsagePercentage = firstItem.CpuUsagePercentage + secondItem.CpuUsagePercentage,

                Time = secondItem.Time,
                Processes = secondItem.Processes,
            };
        }

        public static CollectedData operator /(CollectedData item, int scalar)
        {
            return new CollectedData
            {
                InterruptsTimePercent = item.InterruptsTimePercent / scalar,
                InterruptsPerSeconds = item.InterruptsPerSeconds / scalar,

                UsageRamMBytes = item.UsageRamMBytes / scalar,
                TotalRamMBytes = item.TotalRamMBytes / scalar,
                RamUsagePercentage = item.RamUsagePercentage / scalar,

                LocalDiskUsageMBytes = item.LocalDiskUsageMBytes / scalar,
                LocalDiskTotalMBytes = item.LocalDiskTotalMBytes / scalar,
                LocalDiskUsagePercentage = item.LocalDiskUsagePercentage / scalar,

                CpuUsagePercentage = item.CpuUsagePercentage / scalar,

                ProcessesCount = item.ProcessesCount,
                Time = item.Time,
                Processes = item.Processes
            };
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.Append($"Instance id: {ClientId}\n");
            str.Append($"Processes count: {ProcessesCount}\n");

            str.Append($"UsageRamMBytes: {UsageRamMBytes:0.##}\n");
            str.Append($"TotalRamMBytes: {TotalRamMBytes:0.##}\n");
            str.Append($"RamUsagePercentage: {RamUsagePercentage:0.##}%\n");

            str.Append($"CpuUsagePercentage: {CpuUsagePercentage:0.##}%\n");

            str.Append($"LocalDiskUsageMBytes: {LocalDiskUsageMBytes:0.##}\n");
            str.Append($"LocalDiskTotalMBytes: {LocalDiskTotalMBytes:0.##}\n");
            str.Append($"LocalDiskUsagePercentage: {LocalDiskUsagePercentage:0.##}%\n");
            return str.ToString();
        }
    }

    public class ProcessData
    {
        public string Name { get; set; }
        public float RamMBytes { get; set; }
        public float PRam { get; set; }
        public float PCpu { get; set; }
    }
}