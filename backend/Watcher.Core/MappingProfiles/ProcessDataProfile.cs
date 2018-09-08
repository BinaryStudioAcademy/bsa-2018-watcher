namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using DataAccumulator.Shared.Models;

    public class ProcessDataProfile : Profile
    {
        public ProcessDataProfile()
        {
            CreateMap<ProcessData, ProcessData>();
        }
    }
}
