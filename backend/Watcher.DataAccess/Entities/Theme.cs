using Watcher.Common.Interfaces.Entities;

namespace Watcher.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Theme : Entity<int>, ISoftDeletable
    {
        public override int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string BodyColor { get; set; }

        [Required]
        public string ThemePrimaryColor { get; set; }

        [Required]
        public string ThemeSecondaryColor { get; set; }

        [Required]
        public string ControlsHeight { get; set; }

        //Button        
        [Required]
        public string ButtonFontSize { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public void OnDelete()
        {
            IsDeleted = true;
        }
    }
}
