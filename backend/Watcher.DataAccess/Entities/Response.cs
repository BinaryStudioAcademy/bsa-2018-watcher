using System;
using System.Collections.Generic;
using System.Text;

namespace Watcher.DataAccess.Entities
{
    public class Response : Entity<int>
    {
        public override int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
