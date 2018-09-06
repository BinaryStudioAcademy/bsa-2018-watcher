using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Watcher.Common.Dtos;
using Watcher.Core.Interfaces;
using Watcher.DataAccess.Entities;
using Watcher.DataAccess.Interfaces;

namespace Watcher.Core.Services
{
    public class OrganizationRoleService : IOrganizationRoleService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public OrganizationRoleService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrganizationRoleDto>> GetAllEntitiesAsync()
        {
            var entities = await _uow.OrganizationRoleRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<OrganizationRole>, List<OrganizationRoleDto>>(entities);

            return dtos;
        }
    }
}
