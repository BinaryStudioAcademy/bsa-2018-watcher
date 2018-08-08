using System;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class ResponseDto : EntityDto<int>
    {
        public override int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
        public UserDto User { get; set; }

        public int FeedbackId { get; set; }
        public FeedbackDto Feedback { get; set; }
    }
}
