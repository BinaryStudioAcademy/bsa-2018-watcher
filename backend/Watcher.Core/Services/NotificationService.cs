namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;

    using DataAccumulator.Shared.Models;

    using Microsoft.AspNetCore.SignalR;
    using Microsoft.EntityFrameworkCore;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Hubs;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;

    public class NotificationService : INotificationService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IHubContext<NotificationsHub> _notificationsHub;
        private readonly IEmailProvider _emailProvider;
        private readonly IFileStorageProvider _fileStorageProvider;
        
        public NotificationService(IUnitOfWork uow, 
                                   IMapper mapper, 
                                   IHubContext<NotificationsHub> notificationsHub, 
                                   IEmailProvider emailProvider,
                                   IFileStorageProvider fileStorageProvider)
        {
            _uow = uow;
            _mapper = mapper;
            _notificationsHub = notificationsHub;
            _emailProvider = emailProvider;
            _fileStorageProvider = fileStorageProvider;
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

            var organizationId = notificationRequest.OrganizationId;
            int? instanceId = null;
            if (notificationRequest.InstanceId != null)
            {
                var instance = await _uow.InstanceRepository.GetFirstOrDefaultAsync(i => i.GuidId == notificationRequest.InstanceId);
                if (instance == null) return null;

                organizationId = instance.OrganizationId;
                instanceId = instance.Id;
            }

            var entityNotification = _mapper.Map<NotificationRequest, Notification>(notificationRequest);

            entityNotification.InstanceId = instanceId;
            entityNotification.InstanceGuidId = notificationRequest.InstanceId;

            if (notificationRequest.UserId != null)
            {
                receivers.Add(await _uow.UsersRepository.GetFirstOrDefaultAsync(u => u.Id == notificationRequest.UserId));
            }
            else if (organizationId != null)
            {
                var organizationReceiver =
                    await _uow.OrganizationRepository.GetFirstOrDefaultAsync(o => o.Id == organizationId,
                                                                            include: organizations => organizations.Include(o => o.UserOrganizations)
                                                                                                                    .ThenInclude(uo => uo.User));

                foreach (var userOrganization in organizationReceiver.UserOrganizations)
                    receivers.Add(userOrganization.User);
            }
            else
            {
                return null;
            }
            
            foreach (var receiver in receivers)
            {
                var entity = _mapper.Map<NotificationRequest, Notification>(notificationRequest);
                entity.UserId = receiver.Id;
                entity.InstanceId = instanceId;
                entity.InstanceGuidId = notificationRequest.InstanceId;

                var notificationSetting = await _uow.NotificationSettingsRepository.GetFirstOrDefaultAsync(
                    ns => ns.Type == notificationRequest.Type && ns.UserId == entity.UserId);

                if (notificationSetting == null || notificationSetting.IsDisable) continue;

                entity.NotificationSettingId = notificationSetting.Id;
               
                var created = await _uow.NotificationsRepository.CreateAsync(entity);
                var result = await _uow.SaveAsync();
                if (!result)
                {
                    return null;
                }

                var dto = _mapper.Map<Notification, NotificationDto>(created);
                dto.NotificationSetting = _mapper.Map<NotificationSetting, NotificationSettingDto>(notificationSetting);

                if (notificationSetting.IsEmailable)
                    await _emailProvider.SendMessageOneToOne("watcher@net.com",
                        $"{notificationSetting.Type} Notification", receiver.EmailForNotifications,
                        dto.Text, "");

                notifications.Add(dto);

                if (!NotificationsHub.UsersConnections.ContainsKey(dto.UserId)) continue;

                foreach (string connectionId in NotificationsHub.UsersConnections[dto.UserId])
                    await _notificationsHub.Clients.Client(connectionId)
                        .SendAsync("AddNotification", dto);
            }

            return notifications;
        }

        public async Task<IEnumerable<NotificationDto>> CreateEntityForAllAsync(NotificationRequest notificationRequest)
        {
            var notifications = new List<NotificationDto>();
            
            var usersCount = await _uow.UsersRepository.CountAsync(x => x.Id != null);
            var receivers = await _uow.UsersRepository.GetRangeAsync(count: usersCount);

            foreach (var receiver in receivers)
            {
                var entity = _mapper.Map<NotificationRequest, Notification>(notificationRequest);
                
                entity.UserId = receiver.Id;

                var notificationSetting = await _uow.NotificationSettingsRepository.GetFirstOrDefaultAsync(
                    ns => ns.Type == notificationRequest.Type && ns.UserId == entity.UserId);

                if (notificationSetting == null || notificationSetting.IsDisable) continue;

                entity.NotificationSettingId = notificationSetting.Id;

                var created = await _uow.NotificationsRepository.CreateAsync(entity);
                var result = await _uow.SaveAsync();

                if (!result)
                {
                    return null;
                }

                var dto = _mapper.Map<Notification, NotificationDto>(created);
                dto.NotificationSetting = _mapper.Map<NotificationSetting, NotificationSettingDto>(notificationSetting);

                notifications.Add(dto);

                if (notificationSetting.IsEmailable)
                    await _emailProvider.SendMessageOneToOne("watcher@net.com",
                        $"{notificationSetting.Type} Notification", receiver.EmailForNotifications,
                        entity.Text, "");

                if (!NotificationsHub.UsersConnections.ContainsKey(entity.UserId)) continue;

                foreach (var connectionId in NotificationsHub.UsersConnections[entity.UserId])
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

        public async Task<string> CreateAnomalyReportNotificationAsync(NotificationRequest notificationRequest, InstanceAnomalyReportDto report)
        {
            var receivers = new List<User>();
            var notifications = new List<NotificationDto>();

            if (notificationRequest.InstanceId == null) return string.Empty;

            var instance = await _uow.InstanceRepository.GetFirstOrDefaultAsync(i => i.GuidId == notificationRequest.InstanceId,
                               include: instances => instances.Include(o => o.Organization)
                                   .ThenInclude(uo => uo.UserOrganizations)
                                   .ThenInclude(uo => uo.User));
            if (instance == null) return string.Empty;

            var htmlTable = InstanceAnomalyReportsService.GetHtml(report);
            var htmlDocUrl = await _fileStorageProvider.UploadHtmlFileAsync(htmlTable, report.Id);
            notificationRequest.Text = $"Anomaly Report was created for instance: {instance.Title} (id: {instance.Id}). Download it <a href=\"{htmlDocUrl}\">here</a>";
            notificationRequest.OrganizationId = instance.OrganizationId;
            receivers.AddRange(instance.Organization.UserOrganizations.Select(userOrganization => userOrganization.User));

            foreach (var receiver in receivers)
            {
                var entity = _mapper.Map<NotificationRequest, Notification>(notificationRequest);
                entity.UserId = receiver.Id;
                entity.InstanceId = instance.Id;
                var notificationSetting = await _uow.NotificationSettingsRepository.GetFirstOrDefaultAsync(
                                              ns => ns.Type == notificationRequest.Type && ns.UserId == entity.UserId);

                if (notificationSetting == null || notificationSetting.IsDisable) continue;

                entity.NotificationSettingId = notificationSetting.Id;

                var created = await _uow.NotificationsRepository.CreateAsync(entity);
                var result = await _uow.SaveAsync();
                if (!result)
                {
                    return null;
                }

                var dto = _mapper.Map<Notification, NotificationDto>(created);
                dto.NotificationSetting = _mapper.Map<NotificationSetting, NotificationSettingDto>(notificationSetting);


                if (notificationSetting.IsEmailable)
                {
                    var htmlLetter = InstanceAnomalyReportsService.GetHtmlForLetter(receiver.DisplayName, htmlTable);
                    await _emailProvider.SendMessageOneToOne(
                        "watcher@net.com",
                        $"{notificationSetting.Type} Notification",
                        receiver.EmailForNotifications,
                        dto.Text, htmlLetter);
                }

                notifications.Add(dto);

                if (!NotificationsHub.UsersConnections.ContainsKey(dto.UserId)) continue;

                foreach (string connectionId in NotificationsHub.UsersConnections[dto.UserId])
                    await _notificationsHub.Clients.Client(connectionId).SendAsync("AddNotification", dto);
            }

            return htmlDocUrl;
        }

        private string CreateReportHtmlMessage(string message, AzureMLAnomalyReport report)
        {
            return null;
        }
    }
}
