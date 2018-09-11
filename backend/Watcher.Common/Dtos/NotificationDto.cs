using System;
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

        public int? OrganizationId { get; set; }

        public int? InstanceId { get; set; }

        public string UserId { get; set; }

        public bool WasRead { get; set; }

        public int NotificationSettingId { get; set; }
        public NotificationSettingDto NotificationSetting { get; set; }
    }
}
