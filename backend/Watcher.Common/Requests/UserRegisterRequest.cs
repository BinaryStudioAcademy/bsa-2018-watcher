namespace Watcher.Common.Requests
{
    using System.ComponentModel.DataAnnotations;

    public class UserRegisterRequest
    {
        public UserRegisterRequest() { }

        [Required]
        public string Uid { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string PhotoURL { get; set; }

        [Required]
        public string RefreshToken { get; set; }

        [Required]
        public bool IsNewUser { get; set; }

        [Required]
        public string CompanyName { get; set; }
        [Required]

        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }

    }
}
