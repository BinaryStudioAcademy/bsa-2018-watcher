using DataAccumulator.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccumulator.DataAccessLayer.Interfaces
{
    public interface ILogRepository
    {
        Task<IEnumerable<ActionLog>> GetAllLogs(Guid instanceId);

        Task AddEntity(ActionLog actionLog);
    }
}
