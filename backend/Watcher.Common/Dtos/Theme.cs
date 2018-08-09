using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{
    [ExportClassToTypescript]
    public class Theme : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FontFamily { get; set; }

        public string BackgroundColor { get; set; }
    }
}
