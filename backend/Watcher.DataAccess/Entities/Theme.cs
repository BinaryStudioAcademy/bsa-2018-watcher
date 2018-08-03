namespace Watcher.DataAccess.Entities
{
    public class Theme : Entity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public string FontFamily { get; set; }
        public string BackgroundColor { get; set; }
    }
}
