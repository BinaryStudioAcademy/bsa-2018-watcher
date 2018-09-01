namespace Watcher.DataAccess.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Watcher.Common.Enums;
    using Watcher.Common.Interfaces.Entities;

    public class Chat : Entity<int>, ISoftDeletable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ChatType Type { get; set; }

        public string CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public int? OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public IList<Message> Messages { get; set; }

        public IList<NotificationSetting> UsersSettings { get; set; }

        public IList<UserChat> UserChats { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public void OnDelete()
        {
            if (Messages != null)
            {
                foreach (var message in Messages)
                {
                    message.OnDelete();
                }
            }

            IsDeleted = true;
        }
    }
}
