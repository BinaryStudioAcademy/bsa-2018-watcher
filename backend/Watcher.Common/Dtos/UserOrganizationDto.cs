using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class UserOrganizationDto
    {
        public int UserId { get; set; }
        public UserDto User { get; set; }

        public int OrganizationId { get; set; }
        public OrganizationDto Organization { get; set; }
    }
}
