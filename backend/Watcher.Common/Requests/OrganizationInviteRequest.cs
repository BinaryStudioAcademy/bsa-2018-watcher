namespace Watcher.Common.Requests
{
    using System;
    using Watcher.Common.Enums;

    public class OrganizationInviteRequest
    {
        public string Link { get; set; }

        public int OrganizationId { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ExperationDate { get; set; }

        public string CreatedByUserId { get; set; }

        public OrganizationInviteState State { get; set; }
    }
}
