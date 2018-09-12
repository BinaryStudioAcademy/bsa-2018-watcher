using System;
using System.Collections.Generic;
using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class InstanceDto : IEntity<int>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public string Platform { get; set; }

        public bool IsActive { get; set; }

        public Guid GuidId { get; set; }

        public bool AggregationForHour { get; set; }
        public bool AggregationForDay { get; set; }
        public bool AggregationForMonth { get; set; }
        public bool AggregationForWeek { get; set; }

        public DateTime StatusCheckedAt { get; set; }

        public float CpuMaxPercent { get; set; }
        public float RamMaxPercent { get; set; }
        public float DiskMaxPercent { get; set; }

        public OrganizationDto Organization { get; set; }
        
        public IList<DashboardDto> Dashboards { get; set; }
    }
}
