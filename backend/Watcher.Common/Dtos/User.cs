using System;
using System.Collections.Generic;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class User : Entity<int>
    {
        public override int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int NotificationSettingId { get; set; }

        public IList<int> UserOrganizationsId { get; set; }

        public IList<int> NotificationsId { get; set; }

        public IList<int> FeedbacksId { get; set; }

        public IList<int> ResponsesId { get; set; }

        public IList<int> MessagesId { get; set; }

        public IList<int> CreatedChatsId { get; set; }
    }
}
