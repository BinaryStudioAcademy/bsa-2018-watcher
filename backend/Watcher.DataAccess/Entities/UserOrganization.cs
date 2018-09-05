using System.ComponentModel.DataAnnotations.Schema;

namespace Watcher.DataAccess.Entities
{
    public class UserOrganization
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public int OrganizationRoleId { get; set; }
        public OrganizationRole OrganizationRole { get; set; }
    }
}
