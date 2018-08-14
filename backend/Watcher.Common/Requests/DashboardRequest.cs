namespace Watcher.Common.Requests
{
    using System.ComponentModel.DataAnnotations;

    public class DashboardRequest
    {
        public DashboardRequest() { }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [Range(1, int.MaxValue - 1)]
        public int InstanceId { get; set; }
    }
}
