using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Timers;

namespace DataCollector
{
#if Linux
    public class Collector
    {
        private static readonly Lazy<Collector> Value = new Lazy<Collector>(() => new Collector());

        private Timer _tm;

        private List<ProcessData> processData;

        public ConcurrentBag<CollectedData> Data;

        private Collector()
        {
            Data = new ConcurrentBag<CollectedData>();
          
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
                    AvaliableRamBytes = GetFreeRam(),
                    //InterruptsPerSeconds = _systemCounters["Interrupts"].NextValue(),
                    LocalDiskFreeMBytes = GetDiscFree(),
                    CpuUsagePercent = GetUsageCpuPercentages(),
                    RamUsagePercent = GetUsageRamPercentages(),
                    //InterruptsTimePercent = _systemCounters["InterruptsTime"].NextValue(),
                    LocalDiskFreeSpacePercent = GetLocalDiskFreeSpacePercent(),
                    
                    ProcessesCount = GetProcesses().Count,
                    ProcessesCpu = GetProcessesCpu(),
                    ProcessesRam = GetProcessesRam(),
                    Time = DateTime.Now
                };
                Data.Add(dataItem);
            }
            catch (Exception e)
            {
                 // ignored 
            }

            _tm.Start();
        }
        private float GetFreeRam()
        {
            string ramData = Bash("free -b | awk '{print $2 \";\" $3 \";\" $4}'");
            var ramSwap  = ramData.Split("\n");
            var ram = ramSwap[1].Split(";");
            return float.Parse(ram[2], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture) / 1024.0f / 1024.0f;
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

        private float GetDiscFree()
        {
            string strData = Bash("df -t xfs -t ext4 | awk '{print $2 \";\" $3 \";\" $4}'");
            var allParts = strData.Split("\n");
            var disc = allParts[1].Split(";");
            return float.Parse(disc[2], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture)/1024.0f;
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
            string output = Bash("ps -xo pmem,pcpu,command | awk '{print $1 \";\" $2 \";\" $3}'");
            processData = new List<ProcessData>();
            int counter = 0;
            foreach (string row in output.Split("\n"))
            {
                if (counter == 0) continue;
                counter++;
                var cols = row.Split(";");
                if(cols.Length == 3)
                {
                    var pmem = float.Parse(cols[0], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
                    var pcpu = float.Parse(cols[1], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
                    var command = cols[2];

                    processData.Add( new ProcessData
                    {
                        Ram = pmem,
                        Cpu = pcpu,
                        ProcessName = command

                    });
                }
            }
            return processData;
        }

        private Dictionary<string, float> GetProcessesRam()
        {
            Dictionary<string, float> processRam = new Dictionary<string, float>();
            foreach (var item in GetProcesses())
            {
                try
                {
                    processRam.Add(item.ProcessName, item.Ram);
                }
                catch(Exception e)
                {
                    //
                }
            }
            return processRam;
        }

        private Dictionary<string, float> GetProcessesCpu()
        {
            Dictionary<string, float> processRam = new Dictionary<string, float>();
            foreach (var item in GetProcesses())
            {
                try
                {
                    processRam.Add(item.ProcessName, (float)item.Cpu);
                }
                catch(Exception e)
                {
                    //
                }
            }
            return processRam;
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
