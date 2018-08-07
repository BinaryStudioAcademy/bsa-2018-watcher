namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, User>()
                .ForMember(d => d.Id, o => o.Ignore()); // Don't Map Id because It is useless for Ids when updating

            CreateMap<User, UserDto>()
                .ForMember(d => d.Role, o => o.MapFrom(s => s.Role));

            CreateMap<UserRegisterRequest, User>()
                .ForMember(d => d.Id, o => o.UseValue(0));


            CreateMap<UserUpdateRequest, User>()
                .ForMember(d => d.Id, o => o.UseValue(0));
        }
    }
}
