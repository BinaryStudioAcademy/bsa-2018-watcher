using DataAccumulator.DataAccessLayer.Data;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<ActionLog>> GetAllLogs(Guid instanceId)
        {
            try
            {
                return await _context.ActionLogs
                    .Find(data => data.ClientId == instanceId)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task AddEntity(ActionLog actionLog)
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
