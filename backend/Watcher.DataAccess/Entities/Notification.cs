namespace Watcher.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Watcher.Common.Interfaces.Entities;

    public class Notification : Entity<int>, ISoftDeletable
    {
        public override int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public bool WasRead { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int NotificationSettingId { get; set; }
        public NotificationSetting NotificationSetting { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public void OnDelete()
        {
            IsDeleted = true;
        }
    }
}
