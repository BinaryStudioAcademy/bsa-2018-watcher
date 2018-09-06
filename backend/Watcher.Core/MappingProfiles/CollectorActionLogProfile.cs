using AutoMapper;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.Shared.Models;

namespace Watcher.Core.MappingProfiles
{
    public class CollectorActionLogProfile : Profile
    {
        public CollectorActionLogProfile()
        {
            CreateMap<ActionLog, ActionLogDto>();
        }
    }
}
