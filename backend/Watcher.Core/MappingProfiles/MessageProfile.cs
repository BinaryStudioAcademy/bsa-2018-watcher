using System.Collections.Generic;

namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class MessageProfile : Profile
    {
        public MessageProfile()
        {
            CreateMap<Message, Message>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.CreatedAt, o => o.Ignore())
                .ForMember(d => d.ChatId, o => o.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
                
            CreateMap<Message, MessageDto>();

            CreateMap<Message, MessageDto>()
                .ForMember(d => d.ChatName, o => o.MapFrom(d => d.Chat.Name));


            CreateMap<MessageRequest, Message>();

            CreateMap<MessageUpdateRequest, Message>()
                .ForMember(d => d.UserId, o => o.Ignore())
                .ForMember(d => d.User, o => o.Ignore())
                .ForMember(d => d.ChatId, o => o.Ignore())
                .ForMember(d => d.Chat, o => o.Ignore());
        }
    }
}
