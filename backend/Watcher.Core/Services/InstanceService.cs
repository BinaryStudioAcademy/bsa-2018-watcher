using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class InstanceService: IInstanceService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public InstanceService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InstanceDto>> GetAllEntitiesAsync()
        {
            var entities = await _uow.InstanceRepository.GetRangeAsync(include: x => x
                .Include(o => o.Organization)
                .Include(o => o.Dashboards));

            if (entities == null) return null;
            var dtos = _mapper.Map<List<Instance>, List<InstanceDto>>(entities);

            return dtos;
        }

        public async Task<InstanceDto> GetEntityByIdAsync(int id)
        {
            var entity = await _uow.InstanceRepository.GetFirstOrDefaultAsync(predicate: s => s.Id == id,
                include: x => x.Include(o => o.Dashboards)
                               .Include(o => o.Organization));

            if (entity == null) return null;

            var dto = _mapper.Map<Instance, InstanceDto>(entity);

            return dto;
        }
 
        public async Task<IEnumerable<InstanceDto>> GetEntitiesByOrganizationIdAsync(int id)
        {
            var entities = (await _uow.InstanceRepository.GetRangeAsync(include: x => x
               .Include(o => o.Organization)
               .Include(o => o.Dashboards)))
               .Where(o => o.OrganizationId == id)
               .ToList();

            if (entities == null) return null;

            var dtos = _mapper.Map<List<Instance>, List<InstanceDto>>(entities);

            return dtos;
        }

        public async Task<InstanceDto> CreateEntityAsync(InstanceRequest request)
        {
            var entity = _mapper.Map<InstanceRequest, Instance>(request);

            entity = await _uow.InstanceRepository.CreateAsync(entity);

            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Instance, InstanceDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(InstanceRequest request, int id)
        {
            var entity = _mapper.Map<InstanceRequest, Instance>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.InstanceRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            await _uow.InstanceRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }

       
    }
}
