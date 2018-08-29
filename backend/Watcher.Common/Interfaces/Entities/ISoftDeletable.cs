namespace Watcher.Common.Interfaces.Entities
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }

        void OnDelete();
    }
}
