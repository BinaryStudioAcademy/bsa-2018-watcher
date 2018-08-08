using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    public abstract class EntityDto<T> : IEntity<T>
    {
        public abstract T Id { get; set; }
    }
}
