using System.Collections.Generic;
using Watcher.Common.Enums;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class ChatDto : EntityDto<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public ChatType Type { get; set; }

        public int? CreatedById { get; set; }

        public UserDto CreatedBy { get; set; }

        public int? OrganizationId { get; set; }
        public OrganizationDto Organization { get; set; }

        public IList<MessageDto> Messages { get; set; }
    }
}
