namespace Watcher.DataAccess.Entities
{
    public class Role : Entity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
    }
}
