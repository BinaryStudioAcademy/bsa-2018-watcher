using AutoMapper;
using Watcher.Common.Dtos;
using Watcher.DataAccess.Entities;

namespace Watcher.Core.MappingProfiles
{
    public class ThemeProfile : Profile
    {
        public ThemeProfile()
        {
            CreateMap<Theme, ThemeDto>();
            CreateMap<ThemeDto, Theme>();
        }
    }
}
