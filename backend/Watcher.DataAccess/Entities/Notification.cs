using System;
using System.Collections.Generic;
using System.Text;

namespace Watcher.DataAccess.Entities
{
    public class Notification : Entity<int>
    {
        public override int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
