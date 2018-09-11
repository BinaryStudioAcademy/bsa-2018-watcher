using System;
using System.Collections.Generic;
using System.Text;
using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.Shared.Models
{
    public class InstanceSettingsDto : ICollectedDataDto
    {
        // Id - InstanceValidator identification number
        public Guid Id { get; set; }
        // ClientId - Instance identification number
        public Guid ClientId { get; set; }

        public bool IsActive { get; set; }

        public bool RamValidator { get; set; } = true;
        public float RamUsagePercentageMax { get; set; }

        public bool LocalDiskVallidator { get; set; } = true;
        public float LocalDiskUsagePercentageMax { get; set; }

        public bool CpuValidator { get; set; } = true;
        public float CpuUsagePercentageMax { get; set; }
    }
}
