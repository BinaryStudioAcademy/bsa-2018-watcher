using System;
using System.Collections.Generic;

namespace Watcher.Common.Requests
{
    public class InstanceRequest
    {
        public string Title { get; set; }

        public string Address { get; set; }

        public string Platform { get; set; }

        public Guid GuidId { get; set; }

        public bool AggregationForHour { get; set; }
        public bool AggregationForDay { get; set; }
        public bool AggregationForWeek { get; set; }
        public bool AggregationForMonth { get; set; }

        public float CpuMaxPercent { get; set; }
        public float RamMaxPercent { get; set; }
        public float DiskMaxPercent { get; set; }

        public bool IsActive { get; set; }

        public int OrganizationId { get; set; }

        public List<int> DashboardsId { get; set; }
    }
}
