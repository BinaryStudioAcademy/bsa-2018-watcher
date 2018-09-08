using AutoMapper;
using DataAccumulator.DataAccessLayer.Entities;
using Watcher.Common.Dtos.Plots;

namespace Watcher.Core.MappingProfiles
{
    using DataAccumulator.Shared.Models;

    public class CollectedDataProfile: Profile
    {
        public CollectedDataProfile()
        {
            CreateMap<CollectedData, CollectedData>();

            CreateMap<CollectedData, CollectedDataDto>();

            CreateMap<CollectedData, MemoryInfo>();

            CreateMap<CollectedData, PercentageInfo>();

            CreateMap<CollectedData, ProcessesCpuInfo>();

            CreateMap<CollectedData, ProcessesRamInfo>();
        }
    }
}
