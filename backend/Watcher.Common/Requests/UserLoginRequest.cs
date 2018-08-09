namespace Watcher.Common.Requests
{
    using System.ComponentModel.DataAnnotations;

    public class UserLoginRequest
    {
        public UserLoginRequest() { }

        [Required]
        public string Uid { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
