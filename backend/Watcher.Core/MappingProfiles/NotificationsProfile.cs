namespace Watcher.Core.MappingProfiles
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class NotificationsProfile : Profile
    {
        public NotificationsProfile()
        {
            CreateMap<Notification, Notification>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.NotificationSettingId, o => o.Ignore())
                .ForMember(d => d.UserId, o => o.Ignore())
                .ForMember(d => d.CreatedAt, o => o.Ignore());

            CreateMap<Notification, NotificationDto>();

            CreateMap<NotificationDto, Notification>()
                .ForMember(d => d.NotificationSetting, o => o.Ignore());

            CreateMap<NotificationRequest, Notification>();

            CreateMap<NotificationUpdateRequest, Notification>()
                .ForMember(d => d.NotificationSettingId, o => o.Ignore())
                .ForMember(d => d.UserId, o => o.Ignore())
                .ForMember(d => d.CreatedAt, o => o.Ignore());
        }
    }
}
