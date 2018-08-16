namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class NotificationSettingsProfile : Profile
    {
        public NotificationSettingsProfile()
        {
            CreateMap<NotificationSetting, NotificationSetting>()
               .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<NotificationSettingDto, NotificationSetting>();

            CreateMap<NotificationSettingRequest, NotificationSetting>()
                .ForMember(d => d.Id, o => o.Ignore());
        }
    }
}
