using System;
using System.Collections.Generic;
using System.Text;
using Watcher.Common.Interfaces.Entities;

namespace Watcher.Common.Dtos
{
    public class UserProfileDto : IEntity<string>
    {
        public UserProfileDto() { }

        public string Id { get; set; }

        public string DisplayName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Bio { get; set; }

        public string Email { get; set; }

        public string EmailForNotifications { get; set; }

        public string PhotoURL { get; set; }

        public string PhotoType { get; set; }

        public RoleDto Role { get; set; }
    }
}