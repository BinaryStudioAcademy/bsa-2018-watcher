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
    public class FeedbackProfile : Profile
    {
        public FeedbackProfile()
        {
            CreateMap<Feedback, Feedback>()
                .ForMember(f => f.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<FeedbackDto, Feedback>();

            CreateMap<FeedbackRequest, Feedback>()
                .ForMember(f => f.Id, o => o.Ignore())
                .ForMember(d => d.UserId, o => o.MapFrom(s => s.User.Id))
                .ForMember(d => d.User, o => o.Ignore());

            CreateMap<Feedback, FeedbackDto>()
                    .ForMember(d => d.Id, o => o.Ignore());
        }
    }
}
