using System;
using Watcher.Common.Dtos;

namespace Watcher.Common.Requests
{
    public class NotificationRequest
    {
        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? OrganizationId { get; set; }

        public string UserId { get; set; }

        public int NotificationSettingId { get; set; }
    }
}
