namespace Watcher.Common.Dtos
{
    using System;

    public class UserDto
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public RoleDto Role { get; set; }
    }
}
