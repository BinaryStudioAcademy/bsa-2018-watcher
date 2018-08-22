using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.Core.Interfaces;
using Watcher.DataAccess.Entities;
using Watcher.DataAccess.Interfaces;

namespace Watcher.Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public RoleService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RoleDto>> GetAllEntitiesAsync()
        {
            var entities = await _uow.RoleRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<Role>, List<RoleDto>>(entities);

            return dtos;
        }

        public async Task<RoleDto> GetEntityByIdAsync(int id)
        {
            var entity = await _uow.RoleRepository
                .GetFirstOrDefaultAsync(predicate: o => o.Id == id);

            if (entity == null) return null;

            var dto = _mapper.Map<Role, RoleDto>(entity);

            return dto;
        }

        public async Task<RoleDto> CreateEntityAsync(RoleRequest request)
        {
            var entity = _mapper.Map<RoleRequest, Role>(request);

            entity = await _uow.RoleRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Role, RoleDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(RoleDto request, int id)
        {
            var entity = _mapper.Map<RoleDto, Role>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.RoleRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            await _uow.RoleRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
