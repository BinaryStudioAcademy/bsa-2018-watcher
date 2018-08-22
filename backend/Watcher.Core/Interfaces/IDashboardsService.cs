﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;

namespace Watcher.Core.Interfaces
{
    public interface IDashboardsService
    {
        Task<InstanceDto> GetFirstInstanceAsync();

        Task<IEnumerable<DashboardDto>> GetInstanceDashboards(int id);

        Task<DashboardDto> GetDashboardByIdAsync(int id);

        Task<DashboardDto> CreateDashboardAsync(DashboardRequest dashbordRequest);

        Task<bool> UpdateDashboardByIdAsync(DashboardRequest dashbordRequest, int id);

        Task<bool> DeleteDashboardByIdAsync(int id);

    }
}
