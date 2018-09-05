using DataAccumulator.DataAccessLayer.Entities;
using System.Threading.Tasks;

namespace DataAccumulator.DataAccessLayer.Interfaces
{
    public interface ILogRepository
    {
        Task AddEntity(ActionLog actionLog);
    }
}
