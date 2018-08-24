using System;

namespace Watcher.Common.Interfaces.Entities
{
    interface ICollectedData
    {
        Guid Id { get; set; }
        Guid ClientId { get; set; }
        DateTime Time { get; set; }
    }
}
