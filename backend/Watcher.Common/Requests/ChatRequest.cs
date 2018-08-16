namespace Watcher.Common.Requests
{
    using Watcher.Common.Enums;

    public class ChatRequest
    {
        public ChatRequest() { }

        public string Name { get; set; }

        public ChatType Type { get; set; }
            
        public string CreatedById { get; set; }

        public int? OrganizationId { get; set; }
    }
}
