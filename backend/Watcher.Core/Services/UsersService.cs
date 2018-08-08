namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using AutoMapper;

    using Microsoft.EntityFrameworkCore;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;

    public class UsersService : IUsersService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public UsersService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> GetAllEntitiesAsync()
        {
            var samples = await _uow.UsersRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<User>, List<UserDto>>(samples);

            return dtos;
        }

        public async Task<UserDto> GetEntityByIdAsync(string id)
        {
            var sample = await _uow.UsersRepository.GetFirstOrDefaultAsync(s => s.Id == id);

            if (sample == null) return null;

            var dto = _mapper.Map<User, UserDto>(sample);

            return dto;
        }

        public async Task<UserDto> CreateEntityAsync(UserRegisterRequest request)
        {
            //var entity = _mapper.Map<UserRegisterRequest, User>(request);

            //entity = await _uow.UsersRepository.CreateAsync(entity);
            //var result = await _uow.SaveAsync();
            //if (!result)
            //{
            //    return null;
            //}

            //if (entity == null) return null;

            //var dto = _mapper.Map<User, UserDto>(entity);

            var entity = await _uow.UsersRepository.GetFirstOrDefaultAsync(include: users => users.Include(u => u.Role));

            var dto = _mapper.Map<User, UserDto>(entity);

            //var dto = new UserDto()
            //{
            //    Id = request.Uid,
            //    CreatedAt = DateTime.UtcNow,
            //    Role = new RoleDto { Id = 1, Name = "Admin" },
            //    Email = request.Email,
            //    FirstName = request.DisplayName,
            //    SecondName = request.DisplayName,
            //    IsActive = true
            //};

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(UserUpdateRequest request, string id)
        {
            var entity = _mapper.Map<UserUpdateRequest, User>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.UsersRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(string id)
        {
            await _uow.UsersRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<UserDto> CreateEntityAsync(ClaimsPrincipal request)
        {
            var entity = _mapper.Map<ClaimsPrincipal, User>(request);

            entity = await _uow.UsersRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<User, UserDto>(entity);

            return dto;
        }
    }
}
