namespace Watcher.DataAccess.Entities
{
    using Watcher.Common.Enums;

    public class NotificationSetting : Entity<int>
    {
        public override int Id { get; set; }
        public NotificationType Type { get; set; }
        public bool IsMute { get; set; }
        public bool IsDisable { get; set; }
    }
}
