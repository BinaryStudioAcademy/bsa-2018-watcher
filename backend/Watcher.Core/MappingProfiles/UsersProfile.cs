namespace Watcher.Core.MappingProfiles
{
    using System.Linq;
    using System.Security.Claims;

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
                .ForMember(d => d.Id, o => o.UseValue(0))
                .ForMember(d => d.RoleId, o => o.UseValue(2)); // (Id of User)

            CreateMap<ClaimsPrincipal, User>()
                .ForMember(d => d.Id, o => o.UseValue(0))
                .ForMember(d => d.RoleId, o => o.UseValue(2));
                // .ForMember(d => d.Email, o => o.MapFrom(s => s.Claims.FirstOrDefault(c => c.Type == "Some string").Value)); 
            // TODO: Get Claim with user Data, extract email from this data, maybe use deserializer


            CreateMap<UserUpdateRequest, User>()
                .ForMember(d => d.Id, o => o.UseValue(0));
        }
    }
}
