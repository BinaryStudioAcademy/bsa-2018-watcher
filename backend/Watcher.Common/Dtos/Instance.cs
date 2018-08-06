using System.Collections.Generic;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class Instance : Entity<int>
    {
        public override int Id { get; set; }
        public string Address { get; set; }
        public string Platform { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        
        public IList<Dashboard> Dashboards { get; set; }
    }
}
