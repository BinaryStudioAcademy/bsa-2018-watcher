using System;
using System.Collections.Generic;
using System.Text;

namespace Watcher.DataAccess.Entities
{
    public class Organization : Entity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }
    }
}
