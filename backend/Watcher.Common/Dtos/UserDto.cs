using System;
using System.Collections.Generic;
using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class UserDto : IEntity<string>
    {
        public UserDto() { }

        public string Id { get; set; }

        public string DisplayName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Bio { get; set; }

        public string Email { get; set; }

        public string EmailForNotifications { get; set; }

        public bool IsActive { get; set; }

        public string PhotoURL { get; set; }

        public DateTime CreatedAt { get; set; }

        public RoleDto Role { get; set; }

        public int? LastPickedOrganizationId { get; set; }
        public OrganizationDto LastPickedOrganization { get; set; }

        public IList<NotificationSettingDto> NotificationSettings { get; set; }

        public IList<OrganizationDto> Organizations { get; set; }

        public IList<NotificationDto> Notifications { get; set; }

        public IList<FeedbackDto> Feedbacks { get; set; }

        public IList<ResponseDto> Responses { get; set; }

        public IList<MessageDto> Messages { get; set; }

        public IList<ChatDto> CreatedChats { get; set; }

        public IList<ChatDto> Chats { get; set; }
    }
}
