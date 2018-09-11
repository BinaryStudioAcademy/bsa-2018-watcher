using System;

using Watcher.Common.Enums;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Requests
{

    [ExportClassToTypescript]
    public class NotificationRequest
    {
        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? OrganizationId { get; set; }

        public Guid? InstanceId { get; set; }

        public string UserId { get; set; }

        public bool WasRead { get; set; }

        public NotificationType Type { get; set; }

        public int NotificationSettingId { get; set; }
    }
}