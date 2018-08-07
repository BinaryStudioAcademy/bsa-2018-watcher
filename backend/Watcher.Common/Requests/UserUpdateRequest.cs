namespace Watcher.Common.Requests
{
    public class UserUpdateRequest
    {
        public UserUpdateRequest() { }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public bool IsActive { get; set; }

        public string NickName { get; set; }

        public string Bio { get; set; }

        // public string Email { get; set; } // TODO: can't be changed

        // public string CompanyName { get; set; }
    }
}
