using DataAccumulator.DataAccessLayer.Data;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using System;
using System.Threading.Tasks;

namespace DataAccumulator.DataAccessLayer.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly DataAccumulatorContext _context;

        public LogRepository(string ConnectionString, string Database)
        {
            _context = new DataAccumulatorContext(ConnectionString, Database);
        }

        public async Task SaveActionLog(ActionLog actionLog)
        {
            try
            {
                await _context.ActionLogs
                    .InsertOneAsync(actionLog);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
