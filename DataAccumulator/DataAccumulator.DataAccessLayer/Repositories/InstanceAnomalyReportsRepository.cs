namespace DataAccumulator.DataAccessLayer.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DataAccumulator.DataAccessLayer.Data;
    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;
    using DataAccumulator.Shared.Models;

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
            return _context.AnomalyReportsCollection.Find(filter).SortByDescending(report => report.Date).ToListAsync();
        }

        public Task<List<InstanceAnomalyReport>> GetReportsByParametersAsync(Guid instanceId, CollectedDataType type, DateTime @from, DateTime to, int page = 1, int count = 10)
        {
            var query = _context.AnomalyReportsCollection.Find(d => d.ClientId == instanceId 
                                                                    && d.CollectedDataTypeOfReport == type 
                                                                    && d.Date >= @from 
                                                                    && d.Date <= to);

            query.SortByDescending(report => report.Date).Skip(count * (page - 1)).Limit(count);

            return query.ToListAsync();
        }

        public Task<long> CountByParametersAsync(Guid id, CollectedDataType type, DateTime @from, DateTime to)
        {
            var query = _context.AnomalyReportsCollection.Find(d => d.ClientId == id
                                                                    && d.CollectedDataTypeOfReport == type
                                                                    && d.Date >= @from
                                                                    && d.Date <= to);

            if (query != null)
            {
                return query.CountAsync();
            }

            return Task.FromResult((long)0);
        }

        public Task UpdateReportHtmlUrlAsync(Guid reportId, string htmlUrl)
        {
            var filter = Builders<InstanceAnomalyReport>.Filter.Eq(i => i.Id, reportId);
            var updateBuilder = new UpdateDefinitionBuilder<InstanceAnomalyReport>().Set(anomalyReport => anomalyReport.HtmlDocUrl, htmlUrl);
            return _context.AnomalyReportsCollection.UpdateOneAsync(filter, updateBuilder);
        }

        public async Task<bool> RemoveReportsByInstanceIdAsync(Guid instanceId)
        {
            var filter = Builders<InstanceAnomalyReport>.Filter.Eq(i => i.ClientId, instanceId);
            var actionResult = await _context.AnomalyReportsCollection
                                   .DeleteManyAsync(filter)
                                   .ConfigureAwait(false);

            return actionResult.IsAcknowledged
                   && actionResult.DeletedCount > 0;
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
