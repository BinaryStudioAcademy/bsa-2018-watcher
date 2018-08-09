using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class UserOrganizationDto
    {
        public UserDto User { get; set; }

        public OrganizationDto Organization { get; set; }
    }
}
