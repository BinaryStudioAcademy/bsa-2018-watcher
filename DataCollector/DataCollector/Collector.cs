using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Linq;
using System.Threading;

namespace DataCollector
{
#if Windows
    public class Collector
    {
        private static readonly Lazy<Collector> Value = new Lazy<Collector>(() => new Collector());
        private readonly Dictionary<int, PerformanceCounter> _processCpuCounters;
        private readonly Dictionary<string, PerformanceCounter> _systemCounters;

        private Collector()
        {
            _processCpuCounters = new Dictionary<int, PerformanceCounter>();
            _systemCounters = new Dictionary<string, PerformanceCounter>
            {
                { "FreeRam", new PerformanceCounter("Memory", "Available MBytes") },
                { "Interrupts", new PerformanceCounter("Processor", "Interrupts/sec", "_Total") },
                { "DiskFreeMb", new PerformanceCounter("LogicalDisk", "Free Megabytes", "C:") },
                { "CPU", new PerformanceCounter("Processor Information", "% Processor Time", "_Total") },
                { "RAM", new PerformanceCounter("Memory", "% Committed Bytes In Use") },
                { "InterruptsTime", new PerformanceCounter("Processor", "Interrupts/sec", "_Total") },
                { "LocalDisk", new PerformanceCounter("LogicalDisk", "% Free Space", "C:") }
            };
            _systemCounters["CPU"].NextValue();
            Thread.Sleep(1000);
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // Thread.Sleep(5000);
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

            _processCpuCounters.Clear();

            foreach (var item in processes)
            {

                if (item.ProcessName == "Idle") continue; // cpu > 350%

                if (!_processCpuCounters.ContainsKey(item.Id))
                {
                    var cpu = new PerformanceCounter("Process", "% Processor Time", item.ProcessName, true);
                    cpu.NextValue();
                    _processCpuCounters.Add(item.Id, cpu);
                }
            }
            Thread.Sleep(1000);

            var ListCPU = new Dictionary<int, float>();

            foreach (var item in processes)
            {
                if (item.ProcessName == "Idle") continue; // cpu > 350%
                ListCPU.Add(item.Id, (float)Math.Round(_processCpuCounters[item.Id].NextValue() / Environment.ProcessorCount, 2));
            }


            foreach (var item in processes)
            {
                if (item.ProcessName == "Idle") continue; // cpu > 350%
                try
                {
                    var name = item.ProcessName;
                    item.Refresh();
                    var ramMBytes = (item.PrivateMemorySize64 / 1024) / 1024;
                    var pCpu = ListCPU[item.Id];
                    var pRam = (ramMBytes / GetTotalRAM()) * 100;
                    _processCpuCounters[item.Id].Dispose();
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
                    Thread.Sleep(5000);
                }
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
