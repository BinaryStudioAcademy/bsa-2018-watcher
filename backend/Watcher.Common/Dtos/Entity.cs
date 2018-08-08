using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public abstract class Entity<T> : IEntity<T>
    {
        public abstract T Id { get; set; }
    }
}
