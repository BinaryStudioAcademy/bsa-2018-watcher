using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using System.Management;
using System.Linq;
using System.Threading;

namespace DataCollector
{
#if Windows
    public class Collector
    {
        private static readonly Lazy<Collector> Value = new Lazy<Collector>(() => new Collector());

        private float totalRamMbyte;

        private Collector()
        {
            totalRamMbyte = GetTotalRAM();
        }

        public static Collector Instance => Value.Value;

        public CollectedData Collect()
        {
            CollectedData dataItem = new CollectedData();
            try
            {
                float freeRam, cpu, disk, diskTotalMb, diskFreeMb;
                using (PerformanceCounter counter = new PerformanceCounter("Memory", "Available MBytes"))
                {
                    float tmp = counter.NextValue();
                    freeRam = tmp;
                }
                using (PerformanceCounter counter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total"))
                {
                    counter.NextValue();
                    Thread.Sleep(1000);

                    float tmp = counter.NextValue();
                    cpu = tmp;
                }
                using (PerformanceCounter counter = new PerformanceCounter("LogicalDisk", "% Free Space", "C:"))
                {
                    float tmp = counter.NextValue();
                    disk = tmp;
                }
                using (PerformanceCounter counter = new PerformanceCounter("LogicalDisk", "Free Megabytes", "C:"))
                {
                    float tmp = counter.NextValue();
                    diskFreeMb = tmp;
                    diskTotalMb = (diskFreeMb / disk) * 100;
                }


                var allProcesses = GetProcesses();
                dataItem = new CollectedData
                {
                    TotalRamMBytes = totalRamMbyte,
                    RamUsagePercentage = 100 - (freeRam / (totalRamMbyte / 100)),
                    UsageRamMBytes = totalRamMbyte - freeRam,

                    CpuUsagePercentage = cpu,

                    LocalDiskTotalMBytes = diskTotalMb,
                    LocalDiskUsageMBytes = diskTotalMb - diskFreeMb,
                    LocalDiskUsagePercentage = 100 - disk,

                    Processes = allProcesses,
                    ProcessesCount = allProcesses.Count,
                    Time = DateTime.Now
                };
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // ignored
            }
            return dataItem;
        }

        private float GetTotalRAM()
        {
            float totalRam = 1.0f;
            ManagementObjectSearcher ramMonitor =    //query to WMI
            new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory FROM Win32_OperatingSystem");

            foreach (ManagementObject objram in ramMonitor.Get())
            {
                totalRam = Convert.ToUInt64(objram["TotalVisibleMemorySize"]) / 1024;    // Total RAM
                float busyRam = totalRam - Convert.ToUInt64(objram["FreePhysicalMemory"]);// Usage RAM
            }
            return totalRam;
        }


        private List<ProcessData> GetProcesses()
        {
            var result = new List<ProcessData>();
           
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName == "Idle") continue; // cpu > 350%
                float pCpu;
                using (PerformanceCounter counter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName))
                {
                    float tmp = counter.NextValue();
                    pCpu = (float)(Math.Round((double)tmp, 1));
                }

                var name = process.ProcessName;
                float ramMBytes = (float)Math.Round((double)process.WorkingSet64 / 1024 / 1024, 2);


                //var pCpu = (float)Math.Round(counter.NextValue() / Environment.ProcessorCount, 5);
                var pRam = (float)Math.Round((ramMBytes / totalRamMbyte) * 100, 2);

                result.Add(new ProcessData
                {
                    Name = name,
                    RamMBytes = ramMBytes,
                    PCpu = pCpu,
                    PRam = pRam
                });
            }
           
            result = GroupProcesses(result);

            return result; // DODO merge processes if Processes with the same name
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
    }
#endif
}
