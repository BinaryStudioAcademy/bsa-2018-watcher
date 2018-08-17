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
                .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<Message, MessageDto>()
                .ForPath(d => d.Chat.Messages, o => o.MapFrom(s => new List<MessageDto>()));
                // .ForMember(d => d.Chat.Messages, o => o.Ignore());

            CreateMap<MessageRequest, Message>();

            CreateMap<MessageUpdateRequest, Message>()
                .ForMember(d => d.UserId, o => o.Ignore())
                .ForMember(d => d.User, o => o.Ignore())
                .ForMember(d => d.ChatId, o => o.Ignore())
                .ForMember(d => d.Chat, o => o.Ignore());
        }
    }
}
