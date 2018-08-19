using System;
using System.Collections.Generic;
using Watcher.Common.Interfaces.Entities;

namespace Watcher.Common.Dtos.PlotsDtos
{
    public class ProcessesCpuInfo: ICollectedData
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }

        public int ProcessesCount { get; set; }
        public Dictionary<string, float> ProcessesCPU { get; set; }
    }
}
