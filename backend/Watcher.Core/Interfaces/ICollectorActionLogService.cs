using DataAccumulator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Watcher.Core.Interfaces
{
    public interface ICollectorActionLogService
    {
        Task<IEnumerable<ActionLogDto>> GetAllLogs(Guid instanceId);
    }
}
