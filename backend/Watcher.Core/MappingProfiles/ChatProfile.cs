namespace Watcher.Core.MappingProfiles
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class ChatProfile : Profile
    {
        public ChatProfile()
        {
            CreateMap<Chat, Chat>()
                .ForMember(d => d.Id, o => o.Ignore()) // Don't Map Id because It is useless for Ids when updating
                .ForMember(d => d.UsersSettings, o => o.Ignore())
                .ForMember(d => d.CreatedById, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.OrganizationId, o => o.Ignore())
                .ForMember(d => d.Organization, o => o.Ignore());

            CreateMap<Chat, ChatDto>()
                .ForMember(d => d.Users, c => c.MapFrom(o => o.UserChats.Select(uc => uc.User)));
                
            CreateMap<ChatRequest, Chat>()
                .ForMember(d => d.UserChats, o => o.UseValue(new List<UserChat>()));

            CreateMap<ChatUpdateRequest, Chat>();
        }
    }
}
