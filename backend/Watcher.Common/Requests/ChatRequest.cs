﻿namespace Watcher.Common.Requests
{
    using System.Collections.Generic;

    using Watcher.Common.Dtos;
    using Watcher.Common.Enums;

    public class ChatRequest
    {
        public ChatRequest() { }

        public string Name { get; set; }

        public ChatType Type { get; set; }
            
        public string CreatedById { get; set; }

        public int? OrganizationId { get; set; }

        public IList<UserDto> Users { get; set; }

        public IList<NotificationSettingRequest> UsersSettings { get; set; }
    }
}
