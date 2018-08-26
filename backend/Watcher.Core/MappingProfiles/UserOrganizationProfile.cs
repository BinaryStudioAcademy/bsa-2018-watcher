namespace Watcher.Core.MappingProfiles
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class UserOrganizationProfile : Profile
    {
        public UserOrganizationProfile()
        {
            CreateMap<UserOrganization, UserOrganization>(); 

            CreateMap<UserOrganizationDto, UserOrganization>();

            CreateMap<UserOrganizationRequest, UserOrganization>()
                .ForMember(d => d.OrganizationId, o => o.MapFrom(s => s.Organization.Id))
                .ForMember(d => d.UserId, o => o.MapFrom(s => s.User.Id));

            CreateMap<UserOrganization, UserOrganizationDto>()
                .ForMember(d => d.User, o => o.MapFrom(s => s.User))
                .ForMember(d => d.Organization, o => o.MapFrom(s => s.Organization));
            
        }
    }
}
