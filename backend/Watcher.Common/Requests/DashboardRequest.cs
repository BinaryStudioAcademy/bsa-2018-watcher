using System;

namespace Watcher.Common.Requests
{
    public class DashboardRequest
    {
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; }

        public int InstanceId { get; set; }
    }
}
