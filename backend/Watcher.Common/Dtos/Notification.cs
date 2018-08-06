using System;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class Notification : Entity<int>
    {
        public override int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public int? OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
