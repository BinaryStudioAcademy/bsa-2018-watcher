namespace Watcher.Core.MappingProfiles
{
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
                .ForMember(d => d.UserId, o => o.MapFrom(s => s.User.Id))
                .ForMember(d => d.OrganizationRoleId, o => o.MapFrom(s => s.OrganizationRole.Id));

            CreateMap<UserOrganization, UserOrganizationDto>()
                .ForMember(d => d.User, o => o.MapFrom(s => s.User))
                .ForMember(d => d.Organization, o => o.MapFrom(s => s.Organization))
                .ForMember(d => d.OrganizationRole, o => o.MapFrom(s => s.OrganizationRole));
        }
    }
}
