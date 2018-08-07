namespace Watcher.Common.Requests
{
    using System;
    using System.Collections.Generic;

    using Watcher.Common.Dtos;

    public class UserRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int NotificationSettingId { get; set; }
        public NotificationSetting NotificationSetting { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }

        public IList<Notification> Notifications { get; set; }

        public IList<Feedback> Feedbacks { get; set; }

        public IList<Response> Responses { get; set; }

        public IList<Message> Messages { get; set; }

        public IList<Chat> CreatedChats { get; set; }
    }
}
