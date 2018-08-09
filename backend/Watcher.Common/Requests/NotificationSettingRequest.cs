

namespace Watcher.Common.Requests
{
    using Watcher.Common.Enums;

    public class NotificationSettingRequest
    {
        public NotificationSettingRequest() {}

        public NotificationType Type { get; set; }
        public bool IsMute { get; set; }
        public bool IsDisable { get; set; }
        public bool IsEmailable { get; set; }
    }
}
