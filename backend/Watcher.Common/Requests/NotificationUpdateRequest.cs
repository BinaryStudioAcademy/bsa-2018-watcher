namespace Watcher.Common.Requests
{
    public class NotificationUpdateRequest
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool WasRead { get; set; }
    }
}
