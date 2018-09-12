namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;
    public class CollectorAppVersionProfile : Profile
    {
        public CollectorAppVersionProfile()
        {
            CreateMap<CollectorAppVersion, CollectorAppVersion>()
                    .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<CollectorAppVersionDto, CollectorAppVersion>();

            CreateMap<CollectorAppVersionRequest, CollectorAppVersion>();
        }
    }
}
