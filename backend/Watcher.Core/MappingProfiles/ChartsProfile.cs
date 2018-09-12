namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class ChartsProfile : Profile
    {
        public ChartsProfile()
        {
            CreateMap<Chart, Chart>()
                .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<Chart, ChartDto>();

            CreateMap<ChartRequest, Chart>().ForMember(d => d.Id, o => o.UseValue(0));
            // .ForMember(d => d.Sources, o => o.UseValue(string.Empty));

            CreateMap<ChartDto, Chart>();
        }
    }
}
