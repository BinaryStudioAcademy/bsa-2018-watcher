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

            CreateMap<Message, MessageDto>();

            CreateMap<MessageRequest, Message>();

            CreateMap<MessageUpdateRequest, Message>()
                .ForMember(d => d.UserId, o => o.Ignore())
                .ForMember(d => d.User, o => o.Ignore())
                .ForMember(d => d.ChatId, o => o.Ignore())
                .ForMember(d => d.Chat, o => o.Ignore());
        }
    }
}
