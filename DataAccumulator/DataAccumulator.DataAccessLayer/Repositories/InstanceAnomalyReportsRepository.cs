namespace DataAccumulator.DataAccessLayer.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DataAccumulator.DataAccessLayer.Data;
    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;

    using MongoDB.Bson;
    using MongoDB.Driver;

    public class InstanceAnomalyReportsRepository : IInstanceAnomalyReportsRepository
    {
        private readonly DataAccumulatorContext _context;

        public InstanceAnomalyReportsRepository(string ConnectionString, string Database)
        {
            _context = new DataAccumulatorContext(ConnectionString, Database);
        }

        public Task<List<InstanceAnomalyReport>> GetAllReportsAsync()
        {
            return _context.AnomalyReportsCollection
                           .Find(_ => true)
                           .Limit(100)
                           .ToListAsync();
        }

        public Task<IEnumerable<InstanceAnomalyReport>> GetReportsByInstanceIdAsync(Guid instanceId)
        {
            throw new NotImplementedException();
        }

        public Task<InstanceAnomalyReport> GetReportByIdAsync(ObjectId reportId)
        {
            throw new NotImplementedException();
        }

        public Task AddReportAsync(InstanceAnomalyReport report)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveReportByIdAsync(ObjectId reportId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAllReportsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReportExistsAsync(ObjectId reportId)
        {
            throw new NotImplementedException();
        }
    }
}
