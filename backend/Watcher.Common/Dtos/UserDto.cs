namespace Watcher.Common.Dtos
{
    using System;

    public class UserDto
    {
        public UserDto() { }

        public string Id { get; set; }

        public string DisplayName { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public RoleDto Role { get; set; }

        public string NickName { get; set; }

        public string Bio { get; set; }
    }
}
