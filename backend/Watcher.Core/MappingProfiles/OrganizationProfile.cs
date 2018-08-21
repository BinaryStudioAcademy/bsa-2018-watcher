namespace Watcher.Core.MappingProfiles
{
    using System.Linq;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<Organization, Organization>()
                .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<OrganizationDto, Organization>();

            CreateMap<OrganizationRequest, Organization>()
                .ForMember(d => d.Id, o => o.Ignore());

            CreateMap<Organization, OrganizationDto>()
                .ForMember(d => d.UsersId, o => o.MapFrom(s => s.UserOrganizations.Select(i => i.UserId)));
            // .ForMember(d => d.InstancesId, o => o.MapFrom(s => s.Instances.Select(i => i.Id)));
        }
    }
}
