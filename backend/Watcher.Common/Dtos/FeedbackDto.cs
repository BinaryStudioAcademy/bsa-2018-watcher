using System;
using Watcher.Common.Enums;
using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript] 
    public class FeedbackDto : IEntity<int>
    {
        public int Id { get; set; }

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
