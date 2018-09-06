using DataAccumulator.Shared.Models;
using System.Threading.Tasks;

namespace DataAccumulator.BusinessLayer.Interfaces
{
    public interface ILogService
    {
        Task SaveActionLog(ActionLogDto actionLog);
    }
}
