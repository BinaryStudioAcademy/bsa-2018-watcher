namespace Watcher.Common.Requests
{
    using System.Collections.Generic;
    using Watcher.Common.Dtos;

    public class UserOrganizationRequest
    {
        public UserOrganizationRequest() { }

        public UserDto User { get; set; }

        public OrganizationDto Organization { get; set; }
    }
}
