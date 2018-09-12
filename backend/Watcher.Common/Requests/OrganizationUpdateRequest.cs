
namespace Watcher.Common.Requests
{
    using System.Collections.Generic;
    using Watcher.Common.Dtos;
    public class OrganizationUpdateRequest
    {
        public OrganizationUpdateRequest() { }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string WebSite { get; set; }

        public string ContactNumber { get; set; }

        public bool IsActive { get; set; }

        public string ImageURL { get; set; }
        public string ImageType { get; set; }

        public int? ThemeId { get; set; }

        public int? ChatId { get; set; }

        public string CreatedByUserId { get; set; }

        public IList<string> UsersId { get; set; }

        public IList<int> InstancesId { get; set; }

        public IList<NotificationDto> Notifications { get; set; }
    }
}
