using System.Threading.Tasks;
using DataAccumulator.DataAccessLayer.Data;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;

namespace DataAccumulator.DataAccessLayer.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly DataAccumulatorContext _context;

        public LogRepository(DataAccumulatorContext context)
        {
            _context = context;
        }

        public async Task SaveActionLog(ActionLog actionLog)
        {
            
        }
    }
}
