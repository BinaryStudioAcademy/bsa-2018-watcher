namespace Watcher.Common.Dtos
{
    using Watcher.Common.Interfaces.Entities;
    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public class RoleDto : IEntity<int>
    {
        public RoleDto() { }

        public int Id { get; set; }
        
        public string Name { get; set; }
    }
}
