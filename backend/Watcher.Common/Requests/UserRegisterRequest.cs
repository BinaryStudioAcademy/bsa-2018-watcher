namespace Watcher.Common.Requests
{
    public class UserRegisterRequest
    {
        public UserRegisterRequest() { }

        public string Uid { get; set; }

        public string Email { get; set; }

        public string DisplayName { get; set; }

        public string PhotoURL { get; set; }

        public string RefreshToken { get; set; }

        public bool IsNewUser { get; set; }
    }
}
