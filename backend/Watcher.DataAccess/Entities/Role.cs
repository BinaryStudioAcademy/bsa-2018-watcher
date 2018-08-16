namespace Watcher.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Role : Entity<int>
    {
        public Role() { }

        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
