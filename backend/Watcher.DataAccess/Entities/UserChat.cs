namespace Watcher.DataAccess.Entities
{
    public class UserChat
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
