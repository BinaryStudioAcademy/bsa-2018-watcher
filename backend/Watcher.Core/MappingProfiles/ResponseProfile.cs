using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.DataAccess.Entities;

namespace Watcher.Core.MappingProfiles
{
    public class ResponseProfile : Profile
    {
        public ResponseProfile()
        {
            CreateMap<Response, Response>()
                .ForMember(f => f.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<ResponseDto, Response>();

            CreateMap<ResponseRequest, Response>()
                .ForMember(f => f.Id, o => o.Ignore())
                .ForMember(d => d.UserId, o => o.MapFrom(s => s.User.Id))
                .ForMember(d => d.User, o => o.Ignore())
                .ForMember(d => d.FeedbackId, o => o.MapFrom(s => s.Feedback.Id))
                .ForMember(d => d.Feedback, o => o.Ignore());

            CreateMap<Response, ResponseDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id));
        }
    }
}
