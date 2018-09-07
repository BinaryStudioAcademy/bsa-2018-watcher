using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using System.Management;
using System.Linq;

namespace DataCollector
{
#if Windows
    public class Collector
    {
        private static readonly Lazy<Collector> Value = new Lazy<Collector>(() => new Collector());
        private readonly Dictionary<string, PerformanceCounter> _processCpuCounters;
        private readonly Dictionary<string, PerformanceCounter> _processRamCounters;
        private readonly Dictionary<string, PerformanceCounter> _systemCounters;

        private Collector()
        {
            _processCpuCounters = new Dictionary<string, PerformanceCounter>();
            _processRamCounters = new Dictionary<string, PerformanceCounter>();
            _systemCounters = new Dictionary<string, PerformanceCounter>
            {
                { "FreeRam", new PerformanceCounter("Memory", "Available MBytes") },
                { "Interrupts", new PerformanceCounter("Processor", "Interrupts/sec", "_Total") },
                { "DiskFreeMb", new PerformanceCounter("LogicalDisk", "Free Megabytes", "_Total") },
                { "CPU", new PerformanceCounter("Processor Information", "% Processor Time", "_Total") },
                { "RAM", new PerformanceCounter("Memory", "% Committed Bytes In Use") },
                { "InterruptsTime", new PerformanceCounter("Processor", "Interrupts/sec", "_Total") },
                { "LocalDisk", new PerformanceCounter("LogicalDisk", "% Free Space", "_Total") }
            };
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
                    InterruptsPerSeconds = _systemCounters["Interrupts"].NextValue(),
                    InterruptsTimePercent = _systemCounters["InterruptsTime"].NextValue(),

                    TotalRamMBytes = GetTotalRAM(),
                    RamUsagePercentage = 100 - (_systemCounters["FreeRam"].NextValue() / (GetTotalRAM() / 100)),
                    UsageRamMBytes = GetTotalRAM() - _systemCounters["FreeRam"].NextValue(),

                    CpuUsagePercentage = _systemCounters["CPU"].NextValue(),

                    LocalDiskTotalMBytes = GetDiskTotalMbytes(),
                    LocalDiskUsageMBytes = GetDiskUsageMbytes(),
                    LocalDiskUsagePercentage = 100 - _systemCounters["LocalDisk"].NextValue(),

                    Processes = allProcesses,
                    ProcessesCount = allProcesses.Count,
                    Time = DateTime.Now
                };
                
            }
            catch (Exception)
            {
                // ignored
            }
            return dataItem;
        }

        private float GetDiskTotalMbytes()
        {
            return (_systemCounters["DiskFreeMb"].NextValue() / _systemCounters["LocalDisk"].NextValue()) * 100.0f;
        }

        private float GetDiskUsageMbytes()
        {
            return GetDiskTotalMbytes() - _systemCounters["DiskFreeMb"].NextValue();
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
            var processes = Process.GetProcesses();


            foreach (var item in processes)
            {
                //item.pro
                if (!_processRamCounters.ContainsKey(item.ProcessName))
                    _processRamCounters.Add(item.ProcessName,
                        new PerformanceCounter("Process", "Working Set", item.ProcessName, true));

                if (!_processCpuCounters.ContainsKey(item.ProcessName))
                    _processCpuCounters.Add(item.ProcessName,
                        new PerformanceCounter("Process", "% Processor Time", item.ProcessName, true));
            }

            foreach (var item in processes)
            {
                if (item.ProcessName == "Idle") continue; // cpu > 350%
              

                try
                {
                    var name = item.ProcessName;
                    var ramMBytes = _processRamCounters[item.ProcessName].NextValue() / 1024 / 1024;
                    var pCpu = (float)Math.Round(_processCpuCounters[item.ProcessName].NextValue() / Environment.ProcessorCount, 2);
                    var pRam = (ramMBytes / GetTotalRAM()) * 100;

                    result.Add(new ProcessData
                    {
                        Name = name,
                        RamMBytes = ramMBytes,
                        PCpu = pCpu,
                        PRam = pRam
                    });  
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    _processRamCounters.Remove(item.ProcessName);
                }
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
