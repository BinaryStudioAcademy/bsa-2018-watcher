namespace Watcher.Common.Requests
{
    using System.ComponentModel.DataAnnotations;

    public class UserLoginRequest
    {
        public UserLoginRequest() { }

        public UserLoginRequest(string uid, string email)
        {
            Uid = uid;
            Email = email;
        }

        [Required]
        public string Uid { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
