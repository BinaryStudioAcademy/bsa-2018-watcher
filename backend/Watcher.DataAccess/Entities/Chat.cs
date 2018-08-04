namespace Watcher.DataAccess.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Watcher.Common.Enums;

    public class Chat : Entity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ChatType Type { get; set; }

        public int CreatedById { get; set; }

        public User CreatedBy { get; set; }

        public int? OrganizationId { get; set; }
        public Organization Organization { get; set; }

        IList<Message> Messages { get; set; }
    }
}
