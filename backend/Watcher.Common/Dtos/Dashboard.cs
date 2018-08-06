using System;
using System.Collections.Generic;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class Dashboard : Entity<int>
    {
        public override int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }

        public int InstanceId { get; set; }
        public Instance Instance { get; set; }

        public IList<Chart> Charts { get; set; }
    }
}
