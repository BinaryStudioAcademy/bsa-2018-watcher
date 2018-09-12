using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class ThemeDto : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BodyColor { get; set; }

        public string ThemePrimaryColor { get; set; }

        public string ThemeSecondaryColor { get; set; }

        public string ControlsHeight { get; set; }

        public string ButtonFontSize { get; set; }
    }
}