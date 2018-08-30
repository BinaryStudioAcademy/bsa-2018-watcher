using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;


namespace DataCollector
{
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
                var dataItem = new CollectedData
                {
                    AvaliableRamBytes = _systemCounters["FreeRam"].NextValue(),
                    InterruptsPerSeconds = _systemCounters["Interrupts"].NextValue(),
                    LocalDiskFreeMBytes = _systemCounters["DiskFreeMb"].NextValue(),
                    CpuUsagePercent = _systemCounters["CPU"].NextValue(),
                    RamUsagePercent = _systemCounters["RAM"].NextValue(),
                    InterruptsTimePercent = _systemCounters["InterruptsTime"].NextValue(),
                    LocalDiskFreeSpacePercent = _systemCounters["LocalDisk"].NextValue(),
                    ProcessesCpu = GetProcessesCpu(out var processes),
                    ProcessesRam = GetProcessesRam(),
                    ProcessesCount = processes,
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

        private Dictionary<string, float> GetProcessesCpu(out int processesCount)
        {
            var result = new Dictionary<string, float>();
            var processes = Process.GetProcesses();
            processesCount = processes.Length;
            foreach (var item in processes)
            {
                if (!_processCpuCounters.ContainsKey(item.ProcessName))
                    _processCpuCounters.Add(item.ProcessName,
                        new PerformanceCounter("Process", "% Processor Time", item.ProcessName));
                try
                {
                    if (!result.ContainsKey(item.ProcessName))
                        result.Add(item.ProcessName, _processCpuCounters[item.ProcessName].NextValue());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    _processCpuCounters.Remove(item.ProcessName);
                }
            }
           

            return result;
        }

        private Dictionary<string, float> GetProcessesRam()
        {
            var result = new Dictionary<string, float>();
            var processes = Process.GetProcesses();
            foreach (var item in processes)
            {
                if (!_processRamCounters.ContainsKey(item.ProcessName))
                    _processRamCounters.Add(item.ProcessName,
                        new PerformanceCounter("Process", "Working Set", item.ProcessName));
                try
                {
                    if (!result.ContainsKey(item.ProcessName))
                        result.Add(item.ProcessName, _processRamCounters[item.ProcessName].NextValue() / 1024);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    _processRamCounters.Remove(item.ProcessName);
                }
            }

            return result;
        }
    }
}