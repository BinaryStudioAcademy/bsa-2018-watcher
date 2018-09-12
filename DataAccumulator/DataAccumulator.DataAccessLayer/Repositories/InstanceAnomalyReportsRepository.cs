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

        public Task<List<InstanceAnomalyReport>> GetReportsByInstanceIdAsync(Guid instanceId)
        {
            var filter = Builders<InstanceAnomalyReport>.Filter.Eq(i => i.ClientId, instanceId);
            return _context.AnomalyReportsCollection.Find(filter).ToListAsync();
        }

        public Task<InstanceAnomalyReport> GetReportByIdAsync(Guid reportId)
        {
            var filter = Builders<InstanceAnomalyReport>.Filter.Eq(i => i.Id, reportId);
            return _context.AnomalyReportsCollection.Find(filter).FirstOrDefaultAsync();
        }

        public Task AddReportAsync(InstanceAnomalyReport report)
        {
            return _context.AnomalyReportsCollection.InsertOneAsync(report);
        }

        public async Task<bool> RemoveReportByIdAsync(Guid reportId)
        {
            var filter = Builders<InstanceAnomalyReport>.Filter.Eq(i => i.Id, reportId);
            var actionResult = await _context.AnomalyReportsCollection
                                   .DeleteOneAsync(filter)
                                   .ConfigureAwait(false);

            return actionResult.IsAcknowledged
                   && actionResult.DeletedCount > 0;
        }

        public async Task<bool> RemoveAllReportsAsync()
        {
            var actionResult = await _context.AnomalyReportsCollection.DeleteManyAsync(new BsonDocument());
            return actionResult.IsAcknowledged && actionResult.DeletedCount > 0;
        }

        public Task<bool> ReportExistsAsync(Guid reportId)
        {
            return _context.AnomalyReportsCollection.Find(entity => entity.Id == reportId).AnyAsync();
        }
    }
}
