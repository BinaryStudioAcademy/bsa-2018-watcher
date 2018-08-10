using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.Core.Interfaces;
using Watcher.DataAccess.Entities;
using Watcher.DataAccess.Interfaces;

namespace Watcher.Core.Services
{
    public class DashboardsService : IDashboardsService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public DashboardsService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DashboardDto>> GetInstanceDashboards(int id)
        {
            var dashboards = (await _uow.DashboardsRepository.GetRangeAsync()).Where(dash => dash.InstanceId == id).ToList();

            var dtos = _mapper.Map<List<Dashboard>, List<DashboardDto>>(dashboards);

            return dtos;
        }

        public async Task<DashboardDto> GetDashboardByIdAsync(int id)
        {
            var dashboard = await _uow.DashboardsRepository.GetFirstOrDefaultAsync(s => s.Id == id);

            if (dashboard == null) return null;

            var dto = _mapper.Map<Dashboard, DashboardDto>(dashboard);

            return dto;
        }

        public async Task<DashboardDto> CreateDashboardAsync(DashboardRequest dashbordRequest)
        {
            var entity = _mapper.Map<DashboardRequest, Dashboard>(dashbordRequest);

            entity = await _uow.DashboardsRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Dashboard, DashboardDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateDashboardByIdAsync(DashboardRequest dashbordRequest, int id)
        {
            var entity = _mapper.Map<DashboardRequest, Dashboard>(dashbordRequest);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.DashboardsRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteDashboardByIdAsync(int id)
        {
            await _uow.DashboardsRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
