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
        private float totalVirtualRamMbyte;

        private Collector()
        {
           SetTotalRAM();
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
                    TotalVirtualRamMBytes = totalVirtualRamMbyte,
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

        private float SetTotalRAM()
        {
            float totalRam = 1.0f;
            ManagementObjectSearcher ramMonitor =    //query to WMI
            new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject objram in ramMonitor.Get())
            {
                totalRamMbyte = Convert.ToUInt64(objram["TotalVisibleMemorySize"]) / 1024;    // Total RAM
                float busyRam = totalRam - Convert.ToUInt64(objram["FreePhysicalMemory"]) /1024;// Usage RAM
                totalVirtualRamMbyte = Convert.ToUInt64(objram["TotalVirtualMemorySize"]) / 1024;
            }
            return totalRam;
        }


        private List<ProcessData> GetProcesses()
        {
            var result = new List<ProcessData>();

            Process[] processes = Process.GetProcesses();

            var counters = new List<PerformanceCounter>();


            foreach (Process process in processes)
            {
                if (process.ProcessName == "Idle") continue; // cpu > 350%

                var counter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);
                counter.NextValue();
                counters.Add(counter);
            }

            int i = 0;
            Thread.Sleep(10000); // for counters get values


            foreach (Process process in processes)
            {
                if (process.ProcessName == "Idle" ) continue; // cpu > 350%

                counters[i].NextValue();
                float tmp = counters[i].NextValue() / Environment.ProcessorCount ;
                float pCpu = (float)Math.Round(tmp, 2);
                counters[i].Dispose();

                var name = process.ProcessName;
                process.Refresh();
                float ramMBytes = (process.PrivateMemorySize64 / 1024) / 1024;

                
                var pRam = (float)Math.Round((ramMBytes / totalRamMbyte) * 100, 2);

                result.Add(new ProcessData
                {
                    prcID = process.Id,
                    Name = name,
                    RamMBytes = ramMBytes,
                    PCpu = pCpu,
                    PRam = pRam
                });
                ++i;
            }
           
             result = GroupProcesses(result);

            return result;
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
