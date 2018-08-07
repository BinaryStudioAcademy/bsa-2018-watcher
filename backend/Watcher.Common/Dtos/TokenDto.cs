namespace Watcher.Common.Dtos
{
    public class TokenDto
    {
        public TokenDto() { }

        public TokenDto(string token)
        {
            WatcherJWT = token;
        }

        public string WatcherJWT { get; set; }
    }
}
