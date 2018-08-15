namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.DataAccess.Entities;

    public class InstancesProfile : Profile
    {
        public InstancesProfile()
        {
            CreateMap<Instance, Instance>()
                .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<Instance, InstanceDto>();
        }
    }
}
