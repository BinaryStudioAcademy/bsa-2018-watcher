﻿using System;
using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class NotificationDto : IEntity<int>
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public OrganizationDto Organization { get; set; }

        public UserDto User { get; set; }
    }
}
