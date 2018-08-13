﻿namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class ChatProfile : Profile
    {
        public ChatProfile()
        {
            CreateMap<Chat, Chat>()
                .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<Chat, ChatDto>();

            CreateMap<ChatRequest, Chat>()
                .ForMember(d => d.CreatedById, o => o.MapFrom(s => s.CreatedBy.Id))
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.OrganizationId, o => o.MapFrom(s => s.Organization.Id))
                .ForMember(d => d.Organization, o => o.Ignore());

            CreateMap<ChatUpdateRequest, Chat>()
                .ForMember(d => d.CreatedById, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.OrganizationId, o => o.Ignore())
                .ForMember(d => d.Organization, o => o.Ignore());
        }
    }
}
