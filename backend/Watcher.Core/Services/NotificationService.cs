namespace Watcher.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
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

        public async Task<IEnumerable<NotificationDto>> CreateEntityAsync(NotificationRequest notificationRequest)
        {
            var receivers = new List<User>();
            var notifications = new List<NotificationDto>();

            if (notificationRequest.InstanceId != null)
            {
                var instance = await _uow.InstanceRepository.GetFirstOrDefaultAsync(i => i.GuidId == notificationRequest.InstanceId);
                notificationRequest.OrganizationId = instance.OrganizationId;
            }

            if (notificationRequest.UserId != null)
                receivers.Add(await _uow.UsersRepository.GetFirstOrDefaultAsync(u => u.Id == notificationRequest.UserId));
            else
            {
                Organization organizationReceiver =
                    await _uow.OrganizationRepository.GetFirstOrDefaultAsync(o => o.Id == notificationRequest.OrganizationId, 
                                                                            include: organizations => organizations.Include(o => o.UserOrganizations)
                                                                                                                    .ThenInclude(uo => uo.User));

                foreach (UserOrganization userOrganization in organizationReceiver.UserOrganizations)
                    receivers.Add(userOrganization.User);
            }

            foreach (User receiver in receivers)
            {
                notificationRequest.UserId = receiver.Id;

                var notificationSetting = await _uow.NotificationSettingsRepository.GetFirstOrDefaultAsync(
                    ns => ns.Type == notificationRequest.Type && ns.UserId == notificationRequest.UserId);

                if (notificationSetting == null) return null;
                
                if (notificationSetting.IsDisable) continue;

                notificationRequest.NotificationSettingId = notificationSetting.Id;

                var entity = _mapper.Map<NotificationRequest, Notification>(notificationRequest);

                entity = await _uow.NotificationsRepository.CreateAsync(entity);
                var result = await _uow.SaveAsync();
                if (!result)
                {
                    return null;
                }

                entity = await _uow.NotificationsRepository.GetFirstOrDefaultAsync(n => n.Id == entity.Id,
                    include: notify => notify.Include(n => n.NotificationSetting));

                var dto = _mapper.Map<Notification, NotificationDto>(entity);

                if (dto.NotificationSetting.IsEmailable)
                    await _emailProvider.SendMessageOneToOne("watcher@net.com",
                        $"{dto.NotificationSetting.Type} Notification", receiver.EmailForNotifications,
                        dto.Text, "");

                notifications.Add(dto);

                if (!NotificationsHub.UsersConnections.ContainsKey(dto.UserId)) continue;

                foreach (string connectionId in NotificationsHub.UsersConnections[dto.UserId])
                    await _notificationsHub.Clients.Client(connectionId)
                        .SendAsync("AddNotification", dto);
            }

            return notifications;
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
