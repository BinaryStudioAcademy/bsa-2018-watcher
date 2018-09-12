namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class InstanceProfile : Profile
    {
        public InstanceProfile()
        {
            CreateMap<Instance, Instance>()
                .ForMember(d => d.Id, o => o.Ignore());

            CreateMap<Instance, InstanceDto>();

            CreateMap<InstanceDto, Instance>()
                .ForMember(d => d.OrganizationId, o => o.MapFrom(s => s.Organization.Id));

            CreateMap<InstanceRequest, Instance>()
                .ForMember(d => d.Id, o => o.Ignore());

            CreateMap<Instance, InstanceDto>();
        }
    }
}
