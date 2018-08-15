using System;
using System.Collections.Generic;
using System.Text;

namespace Watcher.Core.MappingProfiles
{
    using System.Linq;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;
    public class OrganizationInvitesProfile : Profile
    {
        public OrganizationInvitesProfile()
        {
            CreateMap<OrganizationInvite, OrganizationInvite>()
                    .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<OrganizationInviteDto, OrganizationInvite>();
        }
    }
}
