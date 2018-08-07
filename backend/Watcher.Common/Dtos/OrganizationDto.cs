using System.Collections.Generic;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class OrganizationDto : EntityDto<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public string WebSite { get; set; }

        public string ContactNumber { get; set; }

        public bool IsActive { get; set; }

        public int ThemeId { get; set; }

        public int? ChatId { get; set; }

        public int CreatedByUserId { get; set; }

        public IList<int> UsersId { get; set; }

        public IList<int> InstancesId { get; set; }

        public IList<int> NotificationsId { get; set; }
    }
}
