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
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, Role>()
                .ForMember(f => f.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<RoleDto, Role>();

            CreateMap<RoleRequest, Role>()
                .ForMember(f => f.Id, o => o.Ignore());

            CreateMap<RoleRequest, RoleDto>()
                .ForMember(f => f.Id, o => o.Ignore());

            CreateMap<Role, RoleDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id));
        }
    }
}
