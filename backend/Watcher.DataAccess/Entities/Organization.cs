namespace Watcher.DataAccess.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Organization : Entity<int>
    {
        public override int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int? ThemeId { get; set; }
        public Theme Theme { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }
    }
}
