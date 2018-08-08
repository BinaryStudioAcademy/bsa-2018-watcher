using System;
using System.Collections.Generic;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class DashboardDto : EntityDto<int>
    {
        public override int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }

        public int InstanceId { get; set; }
        public InstanceDto Instance { get; set; }

        public IList<ChartDto> Charts { get; set; }
    }
}
