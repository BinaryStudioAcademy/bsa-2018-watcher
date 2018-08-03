namespace Watcher.DataAccess.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class Instance : Entity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Platform { get; set; }

        ICollection<Dashboard> Dashboards { get; set; }

        //[Required]
        //public int OrganizationId { get; set; }

        //[Required]
        //public Organization Organization { get; set; }
    }
}
