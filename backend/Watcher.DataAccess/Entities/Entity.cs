namespace Watcher.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;

    using Watcher.Common.Interfaces.Entities;

    public abstract class Entity<T> : IEntity<T>
    {
        [Key]
        public abstract T Id { get; set; }
    }
}
