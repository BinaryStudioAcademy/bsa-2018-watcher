using System;
using System.Collections.Generic;

namespace Watcher.Common.Requests
{
    public class InstanceRequest
    {
        public string Title { get; set; }

        public string Address { get; set; }

        public string Platform { get; set; }

        public bool IsActive { get; set; }

        public int OrganizationId { get; set; }

        public Guid GuidId { get; set; }

        public List<int> DashboardsId { get; set; }
    }
}
