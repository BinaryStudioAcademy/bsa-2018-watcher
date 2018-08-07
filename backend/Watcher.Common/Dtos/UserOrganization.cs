using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class UserOrganization
    {
        public int UserId { get; set; }
        public UserDto User { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
