﻿using Watcher.Common.Enums;

namespace Watcher.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Feedback : Entity<int>
    {
        public override int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public ShortAnswerType WillUse { get; set; }
        public LongAnswerType Informatively { get; set; }
        public LongAnswerType Friendliness { get; set; }
        public LongAnswerType Quickness { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int? ResponseId { get; set; }
        public Response Response { get; set; }
    }
}
