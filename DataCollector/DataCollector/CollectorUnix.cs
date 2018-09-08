using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Timers;

namespace DataCollector
{
#if Linux
    public class Collector
    {
        private static readonly Lazy<Collector> Value = new Lazy<Collector>(() => new Collector());

        private List<ProcessData> processData;

        private Collector()
        {
        }

        public static Collector Instance => Value.Value;

        public CollectedData Collect()
        {
            CollectedData dataItem = new CollectedData();
            try
            {
                var allProcesses = GetProcesses();

                dataItem = new CollectedData
                {

                    //InterruptsPerSeconds = _systemCounters["Interrupts"].NextValue(),
                    //InterruptsTimePercent = _systemCounters["InterruptsTime"].NextValue(),

                    TotalRamMBytes = GetTotalRam(),
                    RamUsagePercentage = GetUsageRamPercentages(),
                    UsageRamMBytes = GetUsageRam(),

                    CpuUsagePercentage = GetUsageCpuPercentages(),

                    LocalDiskTotalMBytes = GetDiskTotalMbytes(),
                    LocalDiskUsageMBytes = GetDiskTotalMbytes() - GetDiskFreeMbytes(),
                    LocalDiskUsagePercentage = GetLocalDiskFreeSpacePercent(),

                    Processes = allProcesses,
                    ProcessesCount = allProcesses.Count,
                    Time = DateTime.Now

                };
            }
            catch (Exception e)
            {
                 // ignored 
            }
            return dataItem;
        }
        private float GetTotalRam()
        {
            string ramData = Bash("free -b | awk '{print $2 \";\" $3 \";\" $4}'");
            var ramSwap  = ramData.Split("\n");
            var ram = ramSwap[1].Split(";");
            return float.Parse(ram[0], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture) / 1024.0f / 1024.0f;
        }

        private float GetUsageRam()
        {
            string ramData = Bash("free -b | awk '{print $2 \";\" $3 \";\" $4}'");
            var ramSwap = ramData.Split("\n");
            var ram = ramSwap[1].Split(";");
            return float.Parse(ram[1], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture) / 1024.0f / 1024.0f;
        }

        private float GetUsageCpuPercentages()
        {
            string cpu = Bash(" cat <(grep 'cpu ' /proc/stat) <(sleep 1 && grep 'cpu ' /proc/stat) | awk -v RS=\"\" '{print ($13-$2+$15-$4)*100/($13-$2+$15-$4+$16-$5)}'");
            
            return float.Parse(cpu, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
        }

        private float GetUsageRamPercentages()
        {
            string ramData = Bash("free -b | awk '{print $2 \";\" $3 \";\" $4}'");
            var ramSwap  = ramData.Split("\n");
            var ram = ramSwap[1].Split(";");
            var freeRam = float.Parse(ram[1], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
            var totalRam = float.Parse(ram[0], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
            return freeRam/totalRam*100.0f;
        }

        private float GetDiskTotalMbytes()
        {
            string strData = Bash("df -t xfs -t ext4 | awk '{print $2 \";\" $3 \";\" $4}'");
            var allParts = strData.Split("\n");
            var disc = allParts[1].Split(";");
            return float.Parse(disc[0], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture)/1024.0f;
        }

        private float GetDiskFreeMbytes()
        {
            string strData = Bash("df -t xfs -t ext4 | awk '{print $2 \";\" $3 \";\" $4}'");
            var allParts = strData.Split("\n");
            var disc = allParts[1].Split(";");
            return float.Parse(disc[2], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture) / 1024.0f;
        }

        private float GetLocalDiskFreeSpacePercent()
        {
            string strData = Bash("df -t xfs -t ext4 | awk '{print $2 \";\" $3 \";\" $4 \";\" $5}'");
            var allParts = strData.Split("\n");
            var disc = allParts[1].Split(";");
            return 100.0f - float.Parse(disc[3].Split("%")[0], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture)/1024.0f;
        }

        private List<ProcessData> GetProcesses()
        {
            string output = Bash("ps -xo rss,pmem,pcpu,comm | awk '{print $1 \";\" $2 \";\" $3  \";\" $4}'");
            processData = new List<ProcessData>();
            int counter = 0;
            foreach (string row in output.Split("\n"))
            {
                if (counter == 0)
                {
                    counter++;
                    continue;
                }

                

                var cols = row.Split(";");
                if(cols.Length == 4)
                {
                    processData.Add( new ProcessData
                    {
                        RamMBytes = float.Parse(cols[0], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture),
                        PRam = float.Parse(cols[1], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture),
                        PCpu = float.Parse(cols[2], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture),
                        Name = cols[3]
                    });
                }
            }
            processData = GroupProcesses(processData);


            return processData;
        }

        private List<ProcessData> GroupProcesses(List<ProcessData> processes)
        {
            var temp = processes.GroupBy(proc => proc.Name).Select(
                    group => new ProcessData
                    {
                        Name = group.Key,
                        PCpu = group.Sum(proc => proc.PCpu),
                        PRam = group.Sum(proc => proc.PRam),
                        RamMBytes = group.Sum(proc => proc.RamMBytes)
                    }).ToList();
            return temp;
        }


        private static string Bash(string cmd)
        {
             var escapedArgs = cmd.Replace("\"", "\\\"");
            
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return result;
        }

    }
#endif
}
