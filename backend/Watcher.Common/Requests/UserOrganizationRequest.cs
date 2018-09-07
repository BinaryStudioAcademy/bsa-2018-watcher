namespace Watcher.Common.Requests
{
    using Watcher.Common.Dtos;

    public class UserOrganizationRequest
    {
        public UserOrganizationRequest() { }

        public UserDto User { get; set; }

        public OrganizationDto Organization { get; set; }

        public OrganizationRoleDto OrganizationRole { get; set; }
    }
}
