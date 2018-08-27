namespace Watcher.Common.Requests
{
    public class NotificationSettingUpdateRequest
    {
        public NotificationSettingUpdateRequest() { }

        public int Id { get; set; }

        public bool IsMute { get; set; }
        public bool IsDisable { get; set; }
        public bool IsEmailable { get; set; }
    }
}
