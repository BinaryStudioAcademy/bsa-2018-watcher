using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Watcher.Common.Enums;

using Watcher.Common.Interfaces.Entities;

namespace Watcher.DataAccess.Entities
{
    public class OrganizationInvite : Entity<int>, ISoftDeletable
    {
        public override int Id { get; set; }

        [Required]
        public string Link { get; set; }
        [Required]
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ExperationDate { get; set; }

        public string InviteEmail { get; set; }

        public string InvitedUserId { get; set; }
        public User InvitedUser { get; set; }


        public string CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }

        public OrganizationInviteState State { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}
