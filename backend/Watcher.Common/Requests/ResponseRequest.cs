using System;
using System.Collections.Generic;
using System.Text;
using Watcher.Common.Dtos;
using Watcher.Common.Enums;

namespace Watcher.Common.Requests
{
    public class ResponseRequest
    {
        public ResponseRequest() { }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public UserDto User { get; set; }

        public FeedbackDto Feedback { get; set; }
    }
}
