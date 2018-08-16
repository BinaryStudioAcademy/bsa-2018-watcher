namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class SamplesProfile : Profile
    {
        public SamplesProfile()
        {
            CreateMap<Sample, Sample>()
                .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating
                
            CreateMap<Sample, SampleDto>()
                .ForMember(d => d.DateOfCreation, o => o.MapFrom(s => s.CreationDate));

            CreateMap<SampleRequest, Sample>()
                .ForMember(d => d.Id, o => o.UseValue(0))
                .ForMember(d => d.CreationDate, o => o.MapFrom(s => s.DateOfCreation));
        }
    }
}
