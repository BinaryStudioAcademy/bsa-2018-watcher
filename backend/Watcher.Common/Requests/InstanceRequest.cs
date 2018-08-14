using System;
using System.Collections.Generic;
using System.Text;

namespace Watcher.Common.Requests
{
    public class InstanceRequest
    {
        public string Address { get; set; }

        public string Platform { get; set; }

        public int OrganizationId { get; set; }

        public List<int> DashboardsId { get; set; }
    }
}
