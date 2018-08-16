namespace Watcher.Common.Requests
{
    using System.Collections.Generic;

    using Watcher.Common.Dtos;
    using Watcher.Common.Enums;

    public class ChatRequest
    {
        public ChatRequest() { }

        public string Name { get; set; }

        public ChatType Type { get; set; }
            
        public UserDto CreatedBy { get; set; }

        public OrganizationDto Organization { get; set; }
    }
}
