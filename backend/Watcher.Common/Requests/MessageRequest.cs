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

        public UserDto User { get; set; }

        public ChatDto Chat { get; set; }
    }
}
