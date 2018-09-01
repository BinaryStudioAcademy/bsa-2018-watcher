namespace Watcher.DataAccess.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Watcher.Common.Enums;
    using Watcher.Common.Interfaces.Entities;

    public class Sample : Entity<int>, ISoftDeletable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [Range(2, 1000)]
        public int Count { get; set; }


        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public SampleEnum SampleField { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public Sample() { }

        public void OnDelete()
        {
            IsDeleted = true;
        }
    }
}
