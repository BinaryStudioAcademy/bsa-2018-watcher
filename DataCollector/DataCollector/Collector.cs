using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Timers;

namespace DataCollector
{
    public class Collector
    {
        public ConcurrentBag<CollectedData> data;
        private Dictionary<string, PerformanceCounter> systemCounters;
        private Dictionary<string, PerformanceCounter> processCpuCounters;
        private Dictionary<string, PerformanceCounter> processRamCounters;
        Timer tm;
        public Collector()
        {
            data = new ConcurrentBag<CollectedData>();
            processCpuCounters = new Dictionary<string, PerformanceCounter>();
            processRamCounters = new Dictionary<string, PerformanceCounter>();
            systemCounters = new Dictionary<string, PerformanceCounter>();
            systemCounters.Add("FreeRam", new PerformanceCounter("Memory", "Available MBytes"));
            systemCounters.Add("Interrupts", new PerformanceCounter("Processor", "Interrupts/sec", "_Total"));
            systemCounters.Add("DiskFreeMb", new PerformanceCounter("LogicalDisk", "Free Megabytes", "_Total"));
            systemCounters.Add("CPU", new PerformanceCounter("Processor Information", "% Processor Time", "_Total"));
            systemCounters.Add("RAM", new PerformanceCounter("Memory", "% Committed Bytes In Use"));
            systemCounters.Add("InterruptsTime", new PerformanceCounter("Processor", "Interrupts/sec", "_Total"));
            systemCounters.Add("LocalDisk", new PerformanceCounter("LogicalDisk", "% Free Space", "_Total"));
        }

        public void Start()
        {
            tm = new Timer(500);
            tm.Elapsed += this.Collect;
            tm.AutoReset = false;
            tm.Enabled = true;
        }

        public void Collect(object obj, ElapsedEventArgs args)
        {
            var dataItem = new CollectedData();
            dataItem.AvaliableRamBytes = systemCounters["FreeRam"].NextValue();
            dataItem.InterruptsPerSeconds = systemCounters["Interrupts"].NextValue();
            dataItem.LocalDiskFreeMBytes = systemCounters["DiskFreeMb"].NextValue();
            dataItem.CpuUsagePercent= systemCounters["CPU"].NextValue();
            dataItem.RamUsagePercent = systemCounters["RAM"].NextValue();
            dataItem.InterruptsTimePercent = systemCounters["InterruptsTime"].NextValue();
            dataItem.LocalDiskFreeSpacePercent = systemCounters["LocalDisk"].NextValue();
            dataItem.ProcessesCPU = GetProcessesCPU(out int processes);
            dataItem.ProcessesRAM = GetProcessesRAM();
            dataItem.ProcessesCount = processes;
            dataItem.Time=DateTime.Now;
            data.Add(dataItem);
            tm.Start();
        }

        private Dictionary<string,float> GetProcessesCPU(out int processesCount)
        {
            var result = new Dictionary<string, float>();
            var processes = Process.GetProcesses();
            processesCount = processes.Length;
            foreach(var item in processes)
            {
                if (!processCpuCounters.ContainsKey(item.ProcessName))
                    processCpuCounters.Add(item.ProcessName, new PerformanceCounter("Process", "% Processor Time", item.ProcessName));
                try
                {
                    if (!result.ContainsKey(item.ProcessName))
                        result.Add(item.ProcessName, processCpuCounters[item.ProcessName].NextValue());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    processCpuCounters.Remove(item.ProcessName);
                }
            }
            return result;
        }

        private Dictionary<string, float> GetProcessesRAM()
        {
            var result = new Dictionary<string, float>();
            var processes = Process.GetProcesses();
            foreach (var item in processes)
            {
                if (!processRamCounters.ContainsKey(item.ProcessName))
                    processRamCounters.Add(item.ProcessName, new PerformanceCounter("Process", "Working Set", item.ProcessName));
                try
                {
                    if (!result.ContainsKey(item.ProcessName))
                    result.Add(item.ProcessName, processRamCounters[item.ProcessName].NextValue()/1024);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    processRamCounters.Remove(item.ProcessName);
                }
            }
            return result;
        }
    }
}
