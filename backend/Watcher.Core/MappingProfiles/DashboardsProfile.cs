using AutoMapper;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.DataAccess.Entities;

namespace Watcher.Core.MappingProfiles
{
    using System.Collections.Generic;

    public class DashboardsProfile : Profile
    {
        public DashboardsProfile()
        {
            CreateMap<Dashboard, Dashboard>()
                .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating
                
            CreateMap<Dashboard, DashboardDto>()
                .ForMember(d => d.Charts, o => o.UseValue(new List<ChartDto>()));

            CreateMap<DashboardRequest, Dashboard>()
                .ForMember(d => d.Id, o => o.Ignore());
        }
    }
}
