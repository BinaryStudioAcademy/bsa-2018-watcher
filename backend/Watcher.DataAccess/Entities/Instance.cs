namespace Watcher.DataAccess.Entities
{
    using System;
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

        public Guid GuidId { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        
        public IList<Dashboard> Dashboards { get; set; }
    }
}
