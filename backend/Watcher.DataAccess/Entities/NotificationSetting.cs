namespace Watcher.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    using Watcher.Common.Enums;

    public class NotificationSetting : Entity<int>
    {
        public override int Id { get; set; }

        [Required]
        public NotificationType Type { get; set; }

        [Required]
        public bool IsMute { get; set; }

        [Required]
        public bool IsDisable { get; set; }

        [Required]
        public bool IsEmailable { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public IList<Notification> Notifications { get; set; }
    }
}
