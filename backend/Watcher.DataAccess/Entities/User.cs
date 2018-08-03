namespace Watcher.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using System.Collections.Generic;

    public class User : Entity<int>
    {
        public override int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }
    }
}
