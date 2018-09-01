namespace Watcher.DataAccess.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Watcher.Common.Interfaces.Entities;

    public class Organization : Entity<int>, ISoftDeletable
    {
        public override int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string WebSite { get; set; }

        public string ContactNumber { get; set; }

        public bool IsActive { get; set; }

        public string ImageURL { get; set; }

        public string CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }

        public int? ThemeId { get; set; }
        public Theme Theme { get; set; }

        public Chat Chat { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }

        public IList<Instance> Instances { get; set; }

        public IList<OrganizationInvite> OrganizationInvites { get; set; }

        public void OnDelete()
        {
            if (Instances != null)
            {
                foreach (var instance in Instances)
                {
                    instance.OnDelete();
                }
            }

            if (OrganizationInvites != null)
            {
                foreach (var organizationInvite in OrganizationInvites)
                {
                    organizationInvite.OnDelete();
                }
            }

            IsDeleted = true;
        }
    }
}
