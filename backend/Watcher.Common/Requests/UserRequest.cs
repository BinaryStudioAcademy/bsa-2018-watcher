namespace Watcher.Common.Requests
{
    using System;
    using System.Collections.Generic;

    using Watcher.Common.Dtos;

    public class UserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EmailForNotifications { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DisplayName { get; set; }
        public string Bio { get; set; }

        public int RoleId { get; set; }
        public RoleDto Role { get; set; }

        public int NotificationSettingId { get; set; }
        public NotificationSettingDto NotificationSetting { get; set; }

        public IList<UserOrganizationDto> UserOrganizations { get; set; }

        public IList<NotificationDto> Notifications { get; set; }

        public IList<FeedbackDto> Feedbacks { get; set; }

        public IList<ResponseDto> Responses { get; set; }

        public IList<MessageDto> Messages { get; set; }

        public IList<ChatDto> CreatedChats { get; set; }
    }
}
