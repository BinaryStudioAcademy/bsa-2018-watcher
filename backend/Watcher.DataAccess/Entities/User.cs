namespace Watcher.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using System.Collections.Generic;

    public class User : Entity<int>
    {
        public override int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }
    }
}
