namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.Shared.Models;

    public class InstanceAnomalyReportProfile : Profile
    {
        public InstanceAnomalyReportProfile()
        {
            CreateMap<InstanceAnomalyReport, InstanceAnomalyReport>()
                .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<InstanceAnomalyReport, InstanceAnomalyReportDto>();
        }
    }
}
