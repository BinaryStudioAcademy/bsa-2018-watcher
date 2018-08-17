
namespace Watcher.Common.Dtos
{
    using System;
    using Watcher.Common.Enums;
    using Watcher.Common.Interfaces.Entities;
    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public class OrganizationInviteDto : IEntity<int>
    {
        public int Id { get; set; }


        public string Link { get; set; }

        public int OrganizationId { get; set; }
        public OrganizationDto Organization { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ExperationDate { get; set; }

        public string InviteEmail { get; set; }

        public string InvitedUserId { get; set; }
        public UserDto InvitedUser { get; set; }

        public string CreatedByUserId { get; set; }
        public UserDto CreatedByUser { get; set; }

        public OrganizationInviteState State { get; set; }

    }
}
