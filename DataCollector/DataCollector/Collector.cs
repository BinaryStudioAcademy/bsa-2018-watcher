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
        private Timer _tm;

        public ConcurrentBag<CollectedData> Data;

        private Collector()
        {
            Data = new ConcurrentBag<CollectedData>();
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

            Start();
        }

        // use `/ 1048576` to get ram in MB
        // and `/ (1048576 * 1024)` or `/ 1048576 / 1024` to get ram in GB
        private float GetTotalRAM()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject item in moc)
            {
                return (float)Math.Round(Convert.ToDouble(item.Properties["TotalPhysicalMemory"].Value) / 1048576.0f, 0);
            }

            return 0.0f;
        }

        public static Collector Instance => Value.Value;

        public void Start()
        {
            _tm = new Timer(500);
            _tm.Elapsed += (sender, e) => Collect();
            _tm.AutoReset = false;
            _tm.Enabled = true;
        }

        public void Collect()
        {
            try
            {
                var allProcesses = GetProcesses();
                var dataItem = new CollectedData
                {
                    InterruptsPerSeconds = _systemCounters["Interrupts"].NextValue(),
                    InterruptsTimePercent = _systemCounters["InterruptsTime"].NextValue(),

                    TotalRamMBytes = GetTotalRAM(),
                    RamUsagePercentage = _systemCounters["RAM"].NextValue(),
                    UsageRamMBytes = GetTotalRAM() - _systemCounters["FreeRam"].NextValue(),

                    CpuUsagePercentage = _systemCounters["CPU"].NextValue(),

                    LocalDiskTotalMBytes = GetDiskTotalMbytes(),
                    LocalDiskUsageMBytes = GetDiskUsageMbytes(),
                    LocalDiskUsagePercentage = 100 - _systemCounters["LocalDisk"].NextValue(),

                    Processes = allProcesses,
                    ProcessesCount = allProcesses.Count,
                    Time = DateTime.Now
                };
                Data.Add(dataItem);
                
            }
            catch (Exception)
            {
                // ignored
            }

            _tm.Start();
        }

        private float GetDiskTotalMbytes()
        {
            return (_systemCounters["DiskFreeMb"].NextValue() / _systemCounters["LocalDisk"].NextValue()) * 100.0f;
        }

        private float GetDiskUsageMbytes()
        {
            return GetDiskTotalMbytes() - _systemCounters["DiskFreeMb"].NextValue();
        }

        private List<ProcessData> GetProcesses()
        {
            var result = new List<ProcessData>();
            var processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (!_processRamCounters.ContainsKey(item.ProcessName))
                    _processRamCounters.Add(item.ProcessName,
                        new PerformanceCounter("Process", "Working Set", item.ProcessName));

                if (!_processCpuCounters.ContainsKey(item.ProcessName))
                    _processCpuCounters.Add(item.ProcessName,
                        new PerformanceCounter("Process", "% Processor Time", item.ProcessName));
            }

            foreach (var item in processes)
            {
                if (item.ProcessName == "Idle") continue;

                if (!_processRamCounters.ContainsKey(item.ProcessName))
                    _processRamCounters.Add(item.ProcessName,
                        new PerformanceCounter("Process", "Working Set", item.ProcessName));

                if (!_processCpuCounters.ContainsKey(item.ProcessName))
                    _processCpuCounters.Add(item.ProcessName,
                        new PerformanceCounter("Process", "% Processor Time", item.ProcessName));

                try
                {
                    var name = item.ProcessName;
                    var ramMBytes = _processRamCounters[item.ProcessName].NextValue() / 1024 / 1024;
                    var pCpu = _processCpuCounters[item.ProcessName].NextValue();
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

            return result; // DODO merge processes if Processes with the same name
        } 
    }
#endif
}
