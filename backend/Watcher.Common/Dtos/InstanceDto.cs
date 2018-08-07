using System.Collections.Generic;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class InstanceDto : EntityDto<int>
    {
        public override int Id { get; set; }
        public string Address { get; set; }
        public string Platform { get; set; }

        public int OrganizationId { get; set; }
        public OrganizationDto Organization { get; set; }
        
        public IList<DashboardDto> Dashboards { get; set; }
    }
}
