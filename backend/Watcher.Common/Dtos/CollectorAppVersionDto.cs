using System;
using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class CollectorAppVersionDto : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Version { get; set; }
        public string ExeLink { get; set; }
        public string DebLink { get; set; }
        public string TgzLink { get; set; }
        public bool IsActive { get; set; }
    }
}
