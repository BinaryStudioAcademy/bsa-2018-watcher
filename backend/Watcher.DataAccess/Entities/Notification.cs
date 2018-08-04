namespace Watcher.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Notification : Entity<int>
    {
        public override int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public int? OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
