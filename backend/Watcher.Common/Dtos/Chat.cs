using System.Collections.Generic;
using Watcher.Common.Enums;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class Chat : Entity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public ChatType Type { get; set; }

        public int? CreatedById { get; set; }

        public User CreatedBy { get; set; }

        public int? OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public IList<Message> Messages { get; set; }
    }
}
