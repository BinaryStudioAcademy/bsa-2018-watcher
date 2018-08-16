namespace Watcher.Common.Dtos
{
    public class FirebaseUserDto
    {
        public FirebaseUserDto() { }

        public string Uid { get; set; }

        public string Email { get; set; }

        public string DisplayName { get; set; }

        public string PhotoUrl { get; set; }

        public string RefreshToken { get; set; }

        public bool IsNewUser { get; set; }
    }
}
