namespace Watcher.DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Watcher.Common.Interfaces.Entities;

    public class Dashboard : Entity<int>, ISoftDeletable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public int InstanceId { get; set; }
        public Instance Instance { get; set; }

        public IList<Chart> Charts { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public void OnDelete()
        {
            if (Charts != null)
            {
                foreach (var chart in Charts)
                {
                    chart.OnDelete();
                }
            }

            IsDeleted = true;
        }
    }
}
