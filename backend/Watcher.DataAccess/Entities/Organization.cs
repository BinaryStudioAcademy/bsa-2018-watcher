namespace Watcher.DataAccess.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Organization : Entity<int>
    {
        public override int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ThemeId { get; set; }
        public Theme Theme { get; set; }

        public Chat Chat { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }

        public IList<Instance> Instances { get; set; }

        public IList<Notification> Notifications { get; set; }
    }
}
