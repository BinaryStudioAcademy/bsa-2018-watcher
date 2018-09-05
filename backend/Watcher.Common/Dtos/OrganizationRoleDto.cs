using Watcher.Common.Interfaces.Entities;
using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Dtos
{

    [ExportClassToTypescript]
    public class OrganizationRoleDto: IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
