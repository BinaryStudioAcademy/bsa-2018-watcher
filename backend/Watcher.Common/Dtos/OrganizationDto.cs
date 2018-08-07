using System.Collections.Generic;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class OrganizationDto : EntityDto<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }

        public int ThemeId { get; set; }
        public Theme Theme { get; set; }

        public ChatDto Chat { get; set; }

        public IList<UserOrganizationDto> UserOrganizations { get; set; }

        public IList<InstanceDto> Instances { get; set; }

        public IList<Notification> Notifications { get; set; }
    }
}
