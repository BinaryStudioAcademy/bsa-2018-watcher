namespace Watcher.Common.Requests
{
    using System;
    public class CollectorAppVersionRequest
    {
        public DateTime CreatedAt { get; set; }
        public string Version { get; set; }
        public string ExeLink { get; set; }
        public string DebLink { get; set; }
        public string TgzLink { get; set; }
        public bool IsActive { get; set; }
    }
}