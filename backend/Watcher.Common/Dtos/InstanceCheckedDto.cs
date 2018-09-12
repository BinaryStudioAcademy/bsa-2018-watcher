namespace Watcher.Common.Dtos
{
    using System;

    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public class InstanceCheckedDto
    {
        public Guid InstanceGuidId { get; set; }
        public DateTime StatusCheckedAt { get; set; }
    }
}
