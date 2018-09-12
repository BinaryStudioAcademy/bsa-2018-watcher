namespace DataAccumulator.DataAccessLayer.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DataAccumulator.DataAccessLayer.Entities;

    using MongoDB.Bson;

    public interface IInstanceAnomalyReportsRepository
    {
        Task<List<InstanceAnomalyReport>> GetAllReportsAsync();
        Task<IEnumerable<InstanceAnomalyReport>> GetReportsByInstanceIdAsync(Guid instanceId);
        Task<InstanceAnomalyReport> GetReportByIdAsync(ObjectId reportId);
        Task AddReportAsync(InstanceAnomalyReport report);
        Task<bool> RemoveReportByIdAsync(ObjectId reportId);
        Task<bool> RemoveAllReportsAsync();
        Task<bool> ReportExistsAsync(ObjectId reportId);
    }
}
