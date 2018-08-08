using Watcher.Common.Enums;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class NotificationSettingDto : EntityDto<int>
    {
        public override int Id { get; set; }
        public NotificationType Type { get; set; }
        public bool IsMute { get; set; }
        public bool IsDisable { get; set; }
        public bool IsEmailable { get; set; }
    }
}
