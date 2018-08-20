using Microsoft.AspNetCore.SignalR;

namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;

    using AutoMapper;
    
    using Microsoft.EntityFrameworkCore;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Common.Enums;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Interfaces;
    using Watcher.Core.Hubs;
    using Watcher.DataAccess.Entities;

    public class NotificationService : INotificationService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IHubContext<NotificationsHub> _notificationsHub;

        public NotificationService(IUnitOfWork uow, IMapper mapper, IHubContext<NotificationsHub> notificationsHub)
        {
            _uow = uow;
            _mapper = mapper;
            _notificationsHub = notificationsHub;
        }

        public async Task<IEnumerable<NotificationDto>> GetAllEntitiesAsync()
        {
            var notifications = await _uow.NotificationsRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<Notification>, List<NotificationDto>>(notifications);

            return dtos;
        }

        public async Task<IEnumerable<NotificationDto>> GetEntitiesByUserIdAsync(string userId)
        {
            var user = await _uow.UsersRepository.GetFirstOrDefaultAsync(u => u.Id == userId);

            if (user == null) return null;

            var userNotifications = await _uow.NotificationsRepository.GetRangeAsync(1, int.MaxValue, n => n.UserId == userId || 
                                                                        user.UserOrganizations.Count(uo => uo.OrganizationId == n.OrganizationId) != 0,
                                                                    include: notifications => notifications.Include(n => n.NotificationSetting)
                                                                                                            .Include(n => n.User)
                                                                                                            .Include(n => n.Organization)
                                                                                                            .Include(n => n.NotificationSetting));

            var dtos = _mapper.Map<List<Notification>, List<NotificationDto>>(userNotifications);

            return dtos;
        }

        public async Task<NotificationDto> GetEntityByIdAsync(int id)
        {
            var notification = await _uow.NotificationsRepository.GetFirstOrDefaultAsync(n => n.Id == id);

            if (notification == null) return null;

            var dto = _mapper.Map<Notification, NotificationDto>(notification);

            return dto;
        }

        public async Task<NotificationDto> CreateEntityAsync(NotificationRequest request)
        {
            var entity = _mapper.Map<NotificationRequest, Notification>(request);

            entity = await _uow.NotificationsRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Notification, NotificationDto>(entity);

            return dto;
        }

        public async Task<NotificationDto> CreateEntityAsync(NotificationDto notificationDto, NotificationType notificationType)
        {
            var entity = _mapper.Map<NotificationDto, Notification>(notificationDto);

            var notificationSetting = await _uow.NotificationSettingsRepository.GetFirstOrDefaultAsync(ns => ns.Type == notificationType 
                                                                                                             && ns.UserId == notificationDto.UserId);

            if (notificationSetting == null) return null;

            entity.NotificationSettingId = notificationSetting.Id;

            entity = await _uow.NotificationsRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            var dto = _mapper.Map<Notification, NotificationDto>(entity);

            await _notificationsHub.Clients.User(notificationDto.UserId).SendAsync("AddNotification", notificationDto);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(NotificationUpdateRequest request, int id)
        {
            var entity = _mapper.Map<NotificationUpdateRequest, Notification>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.NotificationsRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            await _uow.NotificationsRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
