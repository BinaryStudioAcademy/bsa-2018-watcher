using Watcher.Common.Interfaces.Entities;

namespace Watcher.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class OrganizationRole : Entity<int>, ISoftDeletable
    {
        public OrganizationRole() { }

        public OrganizationRole(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public void OnDelete()
        {
            IsDeleted = true;
        }
    }
}
