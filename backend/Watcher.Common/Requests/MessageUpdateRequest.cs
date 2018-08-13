namespace Watcher.Common.Requests
{
    using System;

    public class MessageUpdateRequest
    {
        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool WasRead { get; set; }
    }
}
