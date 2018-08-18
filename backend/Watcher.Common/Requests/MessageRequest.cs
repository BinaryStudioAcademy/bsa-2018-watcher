namespace Watcher.Common.Requests
{
    using System;
    using Watcher.Common.Dtos;

    public class MessageRequest
    {
        public MessageRequest() { }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool WasRead { get; set; }

        public string UserId { get; set; }

        public int ChatId { get; set; }
    }
}
