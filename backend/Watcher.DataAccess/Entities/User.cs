namespace Watcher.DataAccess.Entities
{
    using System;

    using System.Collections.Generic;

    public class User : Entity<int>
    {
        public override int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }
    }
}
