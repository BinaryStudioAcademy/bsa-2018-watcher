namespace Watcher.DataAccess.Entities
{
    using System.Collections.Generic;

    public class Organization : Entity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }
    }
}
