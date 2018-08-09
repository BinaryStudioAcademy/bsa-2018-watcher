namespace Watcher.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;

    public class NotificationSettingsService : INotificationSettingsService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public NotificationSettingsService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<NotificationSettingDto>> GetEntitysByUserIdAsync(int userId)
        {
            var entity = await _uow.NotificationSettingsRepository.GetRangeAsync(1, int.MaxValue);

            if (entity == null) return null;

            var dto = _mapper.Map<IEnumerable<NotificationSetting>, IEnumerable<NotificationSettingDto>>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(NotificationSettingRequest request, int id)
        {
            var entity = _mapper.Map<NotificationSettingRequest, NotificationSetting>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.NotificationSettingsRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
