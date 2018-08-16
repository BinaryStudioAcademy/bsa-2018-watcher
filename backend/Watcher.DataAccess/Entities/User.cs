﻿namespace Watcher.DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User : Entity<string>
    {
        public User() { }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public string Bio { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
        
        public int? LastPickedOrganizationId { get; set; }
        public Organization LastPickedOrganization { get; set; }
        
        public IList<NotificationSetting> NotificationSettings { get; set; }

        public IList<UserOrganization> UserOrganizations { get; set; }

        public IList<Notification> Notifications { get; set; }

        public IList<Feedback> Feedbacks { get; set; }

        public IList<Response> Responses { get; set; }

        public IList<Message> Messages { get; set; }

        public IList<Chat> CreatedChats { get; set; }

        public IList<Organization> CreatedOrganizations { get; set; }
    }
}
