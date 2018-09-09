using System;
using System.Collections.Generic;
using System.Text;
using Watcher.Common.Dtos;
using Watcher.Common.Enums;

namespace Watcher.Common.Requests
{
    public class FeedbackRequest
    {
        public FeedbackRequest() { }

        public string Text { get; set; }

        public ShortAnswerType WillUse { get; set; }

        public LongAnswerType Informatively { get; set; }

        public LongAnswerType Friendliness { get; set; }

        public LongAnswerType Quickness { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }

        public UserDto User { get; set; }

        public ResponseDto Response { get; set; }
    }
}
