using System;
using System.Collections.Generic;

namespace Watcher.Common.Requests
{
    public class DashboardRequest
    {
        public string Title { get; set; }

        public int InstanceId { get; set; }

        public List<int> ChartsId { get; set; }
    }
}
