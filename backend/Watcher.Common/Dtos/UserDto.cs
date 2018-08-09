using System;
using System.Collections.Generic;
using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class UserDto : IEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        
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
