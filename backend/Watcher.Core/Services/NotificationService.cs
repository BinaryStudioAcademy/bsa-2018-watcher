namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;

    using AutoMapper;
    
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.SignalR;

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
        private readonly IEmailProvider _emailProvider;

        public NotificationService(IUnitOfWork uow, IMapper mapper, IHubContext<NotificationsHub> notificationsHub, IEmailProvider emailProvider)
        {
            _uow = uow;
            _mapper = mapper;
            _notificationsHub = notificationsHub;
            _emailProvider = emailProvider;
        }

        public async Task<IEnumerable<NotificationDto>> GetAllEntitiesAsync()
        {
            var notifications = await _uow.NotificationsRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<Notification>, List<NotificationDto>>(notifications);

            return dtos;
        }

        public async Task<IEnumerable<NotificationDto>> GetEntitiesByUserIdAsync(string userId)
        {
            var user = await _uow.UsersRepository.GetFirstOrDefaultAsync(u => u.Id == userId, include: users => users.Include(u => u.UserOrganizations));

            if (user == null) return null;

            var userNotifications = await _uow.NotificationsRepository.GetRangeAsync(1, int.MaxValue, n => n.UserId == userId,
                                                                    include: notifications => notifications.Include(n => n.NotificationSetting)
                                                                                                            .Include(n => n.User));

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
        // TODO: this method must be like CreateEntityAsync(NotificationDto notificationDto, NotificationType notificationType)
        //public async Task<NotificationDto> CreateEntityAsync(NotificationRequest request)
        //{
        //    var entity = _mapper.Map<NotificationRequest, Notification>(request);

        //    entity = await _uow.NotificationsRepository.CreateAsync(entity);
        //    var result = await _uow.SaveAsync();
        //    if (!result)
        //    {
        //        return null;
        //    }

        //    if (entity == null) return null;

        //    var dto = _mapper.Map<Notification, NotificationDto>(entity);

        //    return dto;
        //}

        public async Task<IEnumerable<NotificationDto>> CreateEntityAsync(NotificationDto notificationDto, NotificationType notificationType)
        {
            List<User> receivers = new List<User>();
            List<NotificationDto> dtos = new List<NotificationDto>();

            if (notificationDto.UserId != null)
                receivers.Add(await _uow.UsersRepository.GetFirstOrDefaultAsync(u => u.Id == notificationDto.UserId));
            else
            {
                Organization organizationReceiver =
                    await _uow.OrganizationRepository.GetFirstOrDefaultAsync(o => o.Id == notificationDto.OrganizationId, 
                                                                            include: organizations => organizations.Include(o => o.UserOrganizations)
                                                                                                                    .ThenInclude(uo => uo.User));

                foreach (UserOrganization userOrganization in organizationReceiver.UserOrganizations)
                    receivers.Add(userOrganization.User);
            }

            foreach (User receiver in receivers)
            {
                notificationDto.UserId = receiver.Id;

                var notificationSetting = await _uow.NotificationSettingsRepository.GetFirstOrDefaultAsync(ns => ns.Type == notificationType
                                                                                                                 && ns.UserId == notificationDto.UserId);

                if (notificationSetting == null) return null;
                
                if (notificationSetting.IsDisable) continue;

                notificationDto.NotificationSettingId = notificationSetting.Id;

                var entity = _mapper.Map<NotificationDto, Notification>(notificationDto);

                entity = await _uow.NotificationsRepository.CreateAsync(entity);
                var result = await _uow.SaveAsync();
                if (!result)
                {
                    return null;
                }

                entity = await _uow.NotificationsRepository.GetFirstOrDefaultAsync(n => n.Id == entity.Id,
                    include: notifications => notifications.Include(n => n.NotificationSetting));

                var dto = _mapper.Map<Notification, NotificationDto>(entity);

                if (dto.NotificationSetting.IsEmailable)
                    await _emailProvider.SendMessageOneToOne("watcher@net.com",
                        $"{dto.NotificationSetting.Type} Notification", receiver.EmailForNotifications,
                        dto.Text, "");

                dtos.Add(dto);

                if (!NotificationsHub.UsersConnections.ContainsKey(dto.UserId)) continue;

                foreach (string connectionId in NotificationsHub.UsersConnections[dto.UserId])
                    await _notificationsHub.Clients.Client(connectionId)
                        .SendAsync("AddNotification", dto);
            }

            return dtos;
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

        public async Task<bool> UpdateEntitiesAsync(IEnumerable<NotificationUpdateRequest> requests)
        {
            var entities = _mapper.Map<IEnumerable<NotificationUpdateRequest>, IEnumerable<Notification>>(requests);

            foreach (Notification notification in entities)
                await _uow.NotificationsRepository.UpdateAsync(notification);

            // In returns updated entity, you could do smth with it or just leave as it is
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
