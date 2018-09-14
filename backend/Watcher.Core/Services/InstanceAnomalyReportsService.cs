namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;
    using DataAccumulator.Shared.Models;

    using Watcher.Core.Interfaces;

    public class InstanceAnomalyReportsService : IInstanceAnomalyReportsService
    {
        private readonly IInstanceAnomalyReportsRepository _repository;
        private readonly IMapper _mapper;

        public InstanceAnomalyReportsService(IInstanceAnomalyReportsRepository repository,
                                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public static string GetHtml(InstanceAnomalyReportDto report)
        {
            var html = GenerateWholeHtml.GenerateHtml(report);
            GenerateWholeHtml.ConvertToPdf(html);
            return html;
        }

        public static InstanceAnomalyReport GetAnomalyReport(Guid instanceId)
        {
            var parameters = new List<string> { "CPU", "RAM", "DISC" };
            var random = new Random();
            var groups = new List<AzureMLAnomalyGroup>(3);
            var dateTime = DateTime.UtcNow;

            var processes = parameters.Count;
            for (var i = 0; i < processes; i++)
            {
                var warningsCount = random.Next(10, 29);
                groups.Add(new AzureMLAnomalyGroup()
                {
                    Name = parameters[i],
                    Warnings = new List<AzureMLAnomaly>(warningsCount),
                    Anomalies = new List<AzureMLAnomaly>((warningsCount / 2) + 1),
                    Total = random.Next(10, 50)
                });
            }

            foreach (var g in groups)
            {
                for (var i = 0; i < g.Warnings.Capacity; i++)
                {
                    var anomaly = new AzureMLAnomaly
                    {
                        Time = dateTime.AddMinutes(i * 2),
                        Data = random.Next(50, 100)
                    };
                    g.Warnings.Add(anomaly);
                    if (i % 2 == 0)
                    {
                        g.Anomalies.Add(anomaly);
                    }
                }
            }

            var report = new InstanceAnomalyReport
            {
                Id = Guid.NewGuid(),
                Date = DateTime.UtcNow.AddHours(1),
                ClientId = Guid.NewGuid(),
                AnomalyGroups = groups,
                CollectedDataTypeOfReport = CollectedDataType.AggregationForHour
            };

            return report;
        }

        public async Task<List<InstanceAnomalyReportDto>> GetAllReportsAsync()
        {
            var reports = await _repository.GetAllReportsAsync();

            if (reports != null && reports.Count > 0)
            {
                return _mapper.Map<List<InstanceAnomalyReport>, List<InstanceAnomalyReportDto>>(reports);
            }

            return new List<InstanceAnomalyReportDto>();
        }

        public async Task<List<InstanceAnomalyReportDto>> GetReportsByInstanceIdAsync(Guid instanceId)
        {
            var reports = await _repository.GetReportsByInstanceIdAsync(instanceId);

            if (reports != null && reports.Count > 0)
            {
                return _mapper.Map<List<InstanceAnomalyReport>, List<InstanceAnomalyReportDto>>(reports);
            }

            return new List<InstanceAnomalyReportDto>();
        }

        public async Task<InstanceAnomalyReportDto> GetReportByIdAsync(Guid reportId)
        {
            var report = await _repository.GetReportByIdAsync(reportId);

            if (report == null)
            {
                return null;
            }

            return _mapper.Map<InstanceAnomalyReport, InstanceAnomalyReportDto>(report);
        }

        public Task AddReportAsync(InstanceAnomalyReport report)
        {
            if (report != null)
            {
                return _repository.AddReportAsync(report);
            }

            return Task.CompletedTask;
        }

        public Task<bool> RemoveReportByIdAsync(Guid reportId)
        {
            return _repository.RemoveReportByIdAsync(reportId);
        }

        public Task<bool> RemoveAllReportsAsync()
        {
            return _repository.RemoveAllReportsAsync();
        }

        public Task<bool> ReportExistsAsync(Guid reportId)
        {
            return _repository.ReportExistsAsync(reportId);
        }

        public async Task<List<InstanceAnomalyReportDto>> GetReportsInTimeAsync(Guid id, CollectedDataType type, DateTime @from, DateTime to, int page, int count)
        {
            var reports = await _repository.GetReportsByParametersAsync(id, type, from, to, page, count);

            if (reports != null && reports.Count > 0)
            {
                return _mapper.Map<List<InstanceAnomalyReport>, List<InstanceAnomalyReportDto>>(reports);
            }

            return new List<InstanceAnomalyReportDto>();
        }

        public Task<long> GetCountOfReportsAsync(Guid id, CollectedDataType type, DateTime @from, DateTime to)
        {
            return _repository.CountByParametersAsync(id, type, @from, to);
        }
    }
}
