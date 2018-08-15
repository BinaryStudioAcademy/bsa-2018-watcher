
namespace Watcher.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;
    public class OrganizationInvitesService: IOrganizationInvitesService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public OrganizationInvitesService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
    }
}
