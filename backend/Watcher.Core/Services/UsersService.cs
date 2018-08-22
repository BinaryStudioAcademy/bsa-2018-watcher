using Watcher.DataAccess.Entities;

namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Watcher.Common.Dtos;
    using Watcher.Common.Enums;
    using Watcher.Common.Helpers.Utils;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Interfaces;

    public class UsersService : IUsersService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IFileStorageProvider _fileStorageProvider;

        public UsersService(IUnitOfWork uow, IMapper mapper, IFileStorageProvider fileStorageProvider)
        {
            _uow = uow;
            _mapper = mapper;
            _fileStorageProvider = fileStorageProvider;
        }

        public async Task<IEnumerable<UserDto>> GetAllEntitiesAsync()
        {
            var users = await _uow.UsersRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<User>, List<UserDto>>(users);

            return dtos;
        }

        public async Task<IEnumerable<UserDto>> FindEntitiesAsync(string query)
        {
            var users = await _uow.UsersRepository.GetRangeAsync(
                filter: 
                    u => u.DisplayName.Contains(query) ||
                         u.FirstName.Contains(query) ||
                         u.LastName.Contains(query) ||
                         u.Email.Contains(query),
                orderBy: u => u.OrderBy(q => q.FirstName));

            var dtos = _mapper.Map<List<User>, List<UserDto>>(users);

            return dtos;
        }

        public async Task<UserDto> GetEntityByEmailAsync(string email)
        {
            var user = await _uow.UsersRepository.GetFirstOrDefaultAsync(s => s.Email == email,
                             include: users => users.Include(u => u.Role)
                                .Include(u => u.CreatedChats)
                                .Include(u => u.Feedbacks)
                                .Include(u => u.Responses)
                                .Include(u => u.Messages)
                                .Include(u => u.Notifications)
                                .Include(u => u.NotificationSettings)
                                .Include(u => u.LastPickedOrganization)
                                .Include(u => u.UserOrganizations)
                                    .ThenInclude(uo => uo.Organization)
                                .Include(u => u.UserChats)
                                    .ThenInclude(uc => uc.Chat));

            if (user == null) return null;

            var dto = _mapper.Map<User, UserDto>(user);

            return dto;
        }

        public async Task<UserDto> GetEntityByIdAsync(string id)
        {

            var user = await _uow.UsersRepository.GetFirstOrDefaultAsync(s => s.Id == id,
            include: users => users.Include(u => u.Role)
                                                .Include(u => u.CreatedChats)
                                                .Include(u => u.Feedbacks)
                                                .Include(u => u.Responses)
                                                .Include(u => u.Messages)
                                                .Include(u => u.Notifications)
                                                .Include(u => u.NotificationSettings)
                                                .Include(u => u.LastPickedOrganization)
                                                .Include(u => u.UserOrganizations)
                                                    .ThenInclude(uo => uo.Organization)
                                                .Include(u => u.UserChats)
                                                    .ThenInclude(uc => uc.Chat));

            if (user == null) return null;

            var dto = _mapper.Map<User, UserDto>(user);

            return dto;



        }

        public async Task<UserDto> CreateEntityAsync(UserRegisterRequest request)
        {
            var user = await GetEntityByIdAsync(request.Uid);

            if (user != null)
            {
                return user;
            }

            var entity = _mapper.Map<UserRegisterRequest, User>(request);

            var defaultOrganization = new Organization()
            {
                Name = request.CompanyName ?? "Default",
                IsActive = true,
                CreatedByUserId = entity.Id
            };

            entity.NotificationSettings = CreateNotificationSetting();

            entity.UserOrganizations.Add(
               new UserOrganization
               {
                   Organization = defaultOrganization,
                   UserId = entity.Id
               });


            string containerName = "watcher";
            string photoPath = FileHelpers.DownloadImageFromUrl(entity.PhotoURL);
            string newPhotoUrl = await _fileStorageProvider.UploadFileAsync(photoPath, containerName);
            entity.PhotoURL = newPhotoUrl;
            await FileHelpers.DeleteFileByPath(photoPath);

            var createdUser = await _uow.UsersRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();

            if (result)
            {
                createdUser.LastPickedOrganization = defaultOrganization;
                result &= await _uow.SaveAsync();
            }

            if (!result)
            {
                return null;
            }

            var dto = _mapper.Map<User, UserDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(UserUpdateRequest request, string id)
        {
            var entity = _mapper.Map<UserUpdateRequest, User>(request);
            entity.Id = id;

            var existingEntity = await GetEntityByIdAsync(id);

            if (null == existingEntity.PhotoURL)
            {
                entity.PhotoURL = await UpdatePhoto(entity.PhotoURL);
            }
            else if (!existingEntity.PhotoURL.Equals(entity.PhotoURL))
            {
                await _fileStorageProvider.DeleteFileAsync(existingEntity.PhotoURL);
                entity.PhotoURL = await UpdatePhoto(entity.PhotoURL);
            }

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.UsersRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        private async Task<string> UpdatePhoto(string photoURL)
        {
            string containerName = "watcher";
            string newPhotoUrl = await _fileStorageProvider.UploadFileBase64Async(photoURL, containerName);
            return newPhotoUrl;
        }

        public async Task<bool> DeleteEntityByIdAsync(string id)
        {
            await _uow.UsersRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }

        private IList<NotificationSetting> CreateNotificationSetting()
        {
            var notificationSettings = new List<NotificationSetting>();
            foreach (NotificationType suit in (NotificationType[])Enum.GetValues(typeof(NotificationType)))
            {
                notificationSettings.Add(new NotificationSetting
                {
                    Type = suit,
                    IsDisable = false,
                    IsMute = false,
                    IsEmailable = true
                });
            }
            return notificationSettings;
        }

        public async Task<bool> UpdateLastPickedOrganizationAsync(string userId, int organizationId)
        {
            var organization = await _uow.OrganizationRepository.GetFirstOrDefaultAsync(x => x.Id == organizationId,
                include: entity => entity.Include(u => u.UserOrganizations));

            if (organization == null) return false;

            if (organization.UserOrganizations.Any(x => x.UserId == userId) == false)
                return false;

            var user = await _uow.UsersRepository.GetFirstOrDefaultAsync(x => x.Id == userId);

            if (user == null) return false;

            user.LastPickedOrganizationId = organizationId;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.UsersRepository.UpdateAsync(user);
            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
