namespace Watcher.Core.MappingProfiles
{
    using AutoMapper;

    using Watcher.Common.Requests;
    using Watcher.DataAccess.Entities;

    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<UserRequest, User>();
        }
    }
}
