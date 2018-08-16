namespace Watcher.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common.Enums;
    
    public class Chart : Entity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public ChartType Type { get; set; }

        [Required]
        public string Source { get; set; }

        public string ShowCommon { get; set; }

        public int Threshold { get; set; }

        public string MostLoaded { get; set; }

        

        public int DashboardId { get; set; }
        public Dashboard Dashboard { get; set; }
    }
}
