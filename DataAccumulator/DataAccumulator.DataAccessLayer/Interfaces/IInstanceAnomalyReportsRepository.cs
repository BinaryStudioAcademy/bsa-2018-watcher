namespace DataAccumulator.DataAccessLayer.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.Shared.Models;

    public interface IInstanceAnomalyReportsRepository
    {
        Task<List<InstanceAnomalyReport>> GetAllReportsAsync();
        Task<List<InstanceAnomalyReport>> GetReportsByInstanceIdAsync(Guid instanceId);
        Task<InstanceAnomalyReport> GetReportByIdAsync(Guid reportId);
        Task AddReportAsync(InstanceAnomalyReport report);
        Task<bool> RemoveReportByIdAsync(Guid reportId);
        Task<bool> RemoveAllReportsAsync();
        Task<bool> ReportExistsAsync(Guid reportId);

        Task<List<InstanceAnomalyReport>> GetReportsByParametersAsync(Guid instanceId,
                                                                             CollectedDataType type,
                                                                             DateTime @from,
                                                                             DateTime to,
                                                                             int page = 1,
                                                                             int count = 10);

        Task<long> CountByParametersAsync(Guid id, CollectedDataType type, DateTime @from, DateTime to);

        Task UpdateReportHtmlUrlAsync(Guid reportId, string htmlUrl);
    }
}
