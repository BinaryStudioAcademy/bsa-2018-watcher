namespace Watcher.Core.Services
{
    using System.Threading.Tasks;
    using AutoMapper;

    using Watcher.Core.Interfaces;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Interfaces;

    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<bool> UpdateEntityByIdAsync(UserRequest request, int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
