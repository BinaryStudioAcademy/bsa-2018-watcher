namespace DataAccumulator.DataAccessLayer.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DataAccumulator.DataAccessLayer.Entities;

    public interface IInstanceAnomalyReportsRepository
    {
        Task<List<InstanceAnomalyReport>> GetAllReportsAsync();
        Task<List<InstanceAnomalyReport>> GetReportsByInstanceIdAsync(Guid instanceId);
        Task<InstanceAnomalyReport> GetReportByIdAsync(Guid reportId);
        Task AddReportAsync(InstanceAnomalyReport report);
        Task<bool> RemoveReportByIdAsync(Guid reportId);
        Task<bool> RemoveAllReportsAsync();
        Task<bool> ReportExistsAsync(Guid reportId);
    }
}
