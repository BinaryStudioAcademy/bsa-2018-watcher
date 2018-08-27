namespace Watcher.Core.MappingProfiles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<Role, Role>().ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<Role, RoleDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name));


            CreateMap<User, User>().ForMember(
                d => d.Id,
                o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<UserDto, User>()
                 .ForMember(d => d.EmailForNotifications, o => o.MapFrom(s => s.EmailForNotifications));

            CreateMap<User, UserDto>()
                .ForMember(d => d.Role, o => o.MapFrom(s => s.RoleId == 1 ? new Role(s.RoleId, "Admin") : new Role(s.RoleId, "User")))
                .ForMember(d => d.Organizations, o => o.MapFrom(s => s.UserOrganizations.Select(uo => uo.Organization).ToList()))
                .ForMember(d => d.LastPickedOrganization, o => o.MapFrom(s => s.LastPickedOrganization))
                .ForMember(d => d.CreatedChats, o => o.UseValue(new List<ChartDto>()))
                .ForMember(d => d.Chats, o => o.MapFrom(s => s.UserChats.Select(uc => uc.Chat)))
                .ForMember(d => d.Feedbacks, o => o.UseValue(new List<FeedbackDto>()))
                .ForMember(d => d.Messages, o => o.UseValue(new List<MessageDto>()))
                .ForMember(d => d.PhotoURL, o => o.MapFrom(s => s.PhotoURL))
                .ForMember(d => d.EmailForNotifications, o => o.MapFrom(s => s.EmailForNotifications))
                .ForMember(d => d.NotificationSettings, o => o.MapFrom(s => s.NotificationSettings))
                .ForMember(d => d.Notifications, o => o.MapFrom(s => s.Notifications))
                .ForMember(d => d.Responses, o => o.UseValue(new List<ResponseDto>()));

            CreateMap<UserOrganization, UserOrganization>();
            CreateMap<UserOrganization, OrganizationDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Organization.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Organization.Name))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Organization.Email))
                .ForMember(d => d.WebSite, o => o.MapFrom(s => s.Organization.WebSite))
                .ForMember(d => d.ContactNumber, o => o.MapFrom(s => s.Organization.ContactNumber))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Organization.Description));

            CreateMap<UserOrganization, UserDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.User.Id))
                .ForMember(d => d.FirstName, o => o.MapFrom(s => s.User.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(s => s.User.LastName))
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.User.DisplayName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.User.Email))
                .ForMember(d => d.Bio, o => o.MapFrom(s => s.User.Bio))
                .ForMember(d => d.CreatedAt, o => o.MapFrom(s => s.User.CreatedAt))
                .ForMember(d => d.IsActive, o => o.MapFrom(s => s.User.IsActive))
                .ForMember(d => d.PhotoURL, o => o.MapFrom(s => s.User.PhotoURL))
                .ForMember(d => d.Role, o => o.MapFrom(s => s.User.Role))
                .ForMember(d => d.LastPickedOrganization, o => o.MapFrom(s => s.User.LastPickedOrganization)); // TODO: Include

            CreateMap<UserRegisterRequest, User>().ForMember(d => d.Id, o => o.MapFrom(s => s.Uid))
                .ForMember(d => d.CreatedAt, o => o.UseValue(DateTime.UtcNow))
                .ForMember(d => d.IsActive, o => o.UseValue(true))
                .ForMember(d => d.RoleId, o => o.UseValue(2))
                .ForMember(d => d.EmailForNotifications, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
                .ForMember(d => d.UserOrganizations, o => o.UseValue(new List<UserOrganization>()))
                .ForMember(d => d.CreatedOrganizations, o => o.UseValue(new List<Organization>()));

            CreateMap<ClaimsPrincipal, User>().ForMember(d => d.Id, o => o.UseValue(0))
                .ForMember(d => d.RoleId, o => o.UseValue(2));

            // .ForMember(d => d.Email, o => o.MapFrom(s => s.Claims.FirstOrDefault(c => c.Type == "Some string").Value)); 
            // TODO: Get Claim with user Data, extract email from this data, maybe use deserializer
            CreateMap<UserUpdateRequest, User>().ForMember(d => d.Id, o => o.UseValue(0))
                .ForMember(d => d.RoleId, o => o.MapFrom(s => s.Role.Id))
                .ForMember(d => d.Role, o => o.Ignore());
        }
    }
}
