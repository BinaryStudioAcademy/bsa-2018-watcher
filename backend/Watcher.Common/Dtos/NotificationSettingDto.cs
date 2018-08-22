using Watcher.Common.Enums;
using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class NotificationSettingDto : IEntity<int>
    {
        public int Id { get; set; }

        public NotificationType Type { get; set; }

        public bool IsMute { get; set; }

        public bool IsDisable { get; set; }

        public bool IsEmailable { get; set; }

        public string UserId { get; set; }
    }
}
