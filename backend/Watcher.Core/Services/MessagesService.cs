namespace Watcher.Core.Services
{
    using AutoMapper;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Core.Interfaces;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.DataAccess.Interfaces;
    using Watcher.DataAccess.Entities;
    using Microsoft.EntityFrameworkCore;

    public class MessagesService : IMessagesService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MessagesService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MessageDto>> GetAllEntitiesAsync()
        {
            var samples = await _uow.MessagesRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<Message>, List<MessageDto>>(samples);

            return dtos;
        }

        public async Task<MessageDto> GetEntityByIdAsync(int id)
        {
            var sample = await _uow.MessagesRepository.GetFirstOrDefaultAsync(s => s.Id == id,
                include: messages => messages.Include(m => m.User)
                    .Include(m => m.Chat));

            if (sample == null) return null;

            var dto = _mapper.Map<Message, MessageDto>(sample);

            return dto;
        }

        public async Task<MessageDto> CreateEntityAsync(MessageRequest request)
        {
            var entity = _mapper.Map<MessageRequest, Message>(request);

            entity = await _uow.MessagesRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Message, MessageDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(MessageUpdateRequest request, int id)
        {
            var entity = _mapper.Map<MessageUpdateRequest, Message>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.MessagesRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            await _uow.MessagesRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
