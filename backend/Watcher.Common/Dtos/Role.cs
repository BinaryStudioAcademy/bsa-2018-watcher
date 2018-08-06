using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class Role : Entity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
    }
}
