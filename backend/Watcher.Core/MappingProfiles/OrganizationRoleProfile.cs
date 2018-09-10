using AutoMapper;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.DataAccess.Entities;

namespace Watcher.Core.MappingProfiles
{
    public class OrganizationRoleProfile : Profile
    {
        public OrganizationRoleProfile()
        {
            CreateMap<OrganizationRole, OrganizationRole>()
                .ForMember(f => f.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<OrganizationRoleDto, OrganizationRole>();

            CreateMap<OrganizationRoleRequest, OrganizationRole>()
                .ForMember(f => f.Id, o => o.Ignore());

            CreateMap<OrganizationRoleRequest, OrganizationRoleDto>()
                .ForMember(f => f.Id, o => o.Ignore());

            CreateMap<OrganizationRole, OrganizationRoleDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id));
        }
    }
}
