namespace Watcher.Common.Dtos
{
    public class TokenDto
    {
        public TokenDto() { }

        public TokenDto(string token, UserDto userDto = null)
        {
            WatcherJWT = token;
            User = userDto;
        }

        public UserDto User { get; set; }

        public string WatcherJWT { get; set; }
    }
}
