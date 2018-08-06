using System;

namespace Watcher.Common.Dtos
{
    public class DashboardDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime CreatedAt { get; set; }

        public int InstanceId { get; set; }
    }
}
