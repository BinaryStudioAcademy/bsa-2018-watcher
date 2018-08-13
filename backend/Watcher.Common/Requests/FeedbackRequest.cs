using System;
using System.Collections.Generic;
using System.Text;
using Watcher.Common.Dtos;

namespace Watcher.Common.Requests
{
    public class FeedbackRequest
    {
        public FeedbackRequest() { }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public UserDto User { get; set; }

        public ResponseDto Response { get; set; }
    }
}
