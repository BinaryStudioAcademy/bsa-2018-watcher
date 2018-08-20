using System;

namespace Watcher.Common.Interfaces.Entities
{
    interface ICollectedData
    {
        Guid Id { get; set; }
        DateTime Time { get; set; }
    }
}
