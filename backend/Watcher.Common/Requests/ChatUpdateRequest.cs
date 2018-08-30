using System.Collections.Generic;
using Watcher.Common.Dtos;

namespace Watcher.Common.Requests
{
    public class ChatUpdateRequest
    {
        public ChatUpdateRequest() { }

        public string Name { get; set; }

        public IList<NotificationSettingDto> UsersSettings { get; set; }
    }
}
