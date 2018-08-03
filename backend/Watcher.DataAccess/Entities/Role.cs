namespace Watcher.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Role : Entity<int>
    {
        public override int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
