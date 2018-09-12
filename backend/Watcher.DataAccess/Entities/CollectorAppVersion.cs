using System;
using System.Collections.Generic;
using System.Text;
using Watcher.Common.Interfaces.Entities;

namespace Watcher.DataAccess.Entities
{
    public class CollectorAppVersion : Entity<int>
    {
        public override int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Version { get; set; }
        public string ExeLink { get; set; }
        public string DebLink { get; set; } 
        public string TgzLink { get; set; }
        public bool IsActive { get; set; }
    }
}
