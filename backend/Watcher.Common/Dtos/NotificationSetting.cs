using Watcher.Common.Enums;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class NotificationSetting : Entity<int>
    {
        public override int Id { get; set; }
        public NotificationType Type { get; set; }
        public bool IsMute { get; set; }
        public bool IsDisable { get; set; }
    }
}
