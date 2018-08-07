using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class RoleDto : EntityDto<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
    }
}
