using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;

namespace DataCollector
{
    public class CollectorUnix
    {
        private static readonly Lazy<CollectorUnix> Value = new Lazy<CollectorUnix>(() => new CollectorUnix());

        private Timer _tm;

        public ConcurrentBag<CollectedData> Data;

        private CollectorUnix()
        {
            Data = new ConcurrentBag<CollectedData>();
          
            Start();
        }

        public static CollectorUnix Instance => Value.Value;

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
                    //AvaliableRamBytes = _systemCounters["FreeRam"].NextValue(),
                    //InterruptsPerSeconds = _systemCounters["Interrupts"].NextValue(),
                    //LocalDiskFreeMBytes = _systemCounters["DiskFreeMb"].NextValue(),
                    //CpuUsagePercent = _systemCounters["CPU"].NextValue(),
                    //RamUsagePercent = _systemCounters["RAM"].NextValue(),
                    //InterruptsTimePercent = _systemCounters["InterruptsTime"].NextValue(),
                    //LocalDiskFreeSpacePercent = _systemCounters["LocalDisk"].NextValue(),
                    //ProcessesCpu = GetProcessesCpu(out var processes),
                    //ProcessesRam = GetProcessesRam(),
                    //ProcessesCount = processes,
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
    }
}
