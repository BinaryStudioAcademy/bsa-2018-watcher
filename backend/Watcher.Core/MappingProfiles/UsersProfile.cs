﻿namespace Watcher.Core.MappingProfiles
{
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, User>().ForMember(
                d => d.Id,
                o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<User, UserDto>()
                .ForMember(d => d.Role, o => o.MapFrom(s => s.RoleId == 1 ? new Role(s.RoleId, "Admin") : new Role(s.RoleId, "User")))
                .ForMember(d => d.UserOrganizations, o => o.UseValue(new List<UserOrganizationDto>()))
                .ForMember(d => d.CreatedChats, o => o.UseValue(new List<ChartDto>()))
                .ForMember(d => d.Feedbacks, o => o.UseValue(new List<FeedbackDto>()))
                .ForMember(d => d.Messages, o => o.UseValue(new List<MessageDto>()))
                .ForMember(d => d.NotificationSetting, o => o.UseValue(new NotificationSettingDto()))
                .ForMember(d => d.Notifications, o => o.UseValue(new List<NotificationDto>()))
                .ForMember(d => d.Responses, o => o.UseValue(new List<ResponseDto>()));



            CreateMap<UserRegisterRequest, User>().ForMember(d => d.Id, o => o.MapFrom(s => s.Uid))
                .ForMember(d => d.CreatedAt, o => o.UseValue(DateTime.UtcNow))
                .ForMember(d => d.IsActive, o => o.UseValue(true))
                .ForMember(d => d.RoleId, o => o.UseValue(2)); // (Id of User)

            CreateMap<ClaimsPrincipal, User>().ForMember(d => d.Id, o => o.UseValue(0))
                .ForMember(d => d.RoleId, o => o.UseValue(2));

            // .ForMember(d => d.Email, o => o.MapFrom(s => s.Claims.FirstOrDefault(c => c.Type == "Some string").Value)); 
            // TODO: Get Claim with user Data, extract email from this data, maybe use deserializer
            CreateMap<UserUpdateRequest, User>().ForMember(d => d.Id, o => o.UseValue(0));
        }
    }
}