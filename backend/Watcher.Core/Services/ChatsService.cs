using System.Linq;

namespace Watcher.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Interfaces;
    using Watcher.DataAccess.Entities;

    public class ChatsService : IChatsService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ChatsService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ChatDto>> GetAllEntitiesAsync()
        {
            var samples = await _uow.ChatsRepository.GetRangeAsync();

            var dtos = _mapper.Map<List<Chat>, List<ChatDto>>(samples);

            return dtos;
        }

        public async Task<IEnumerable<ChatDto>> GetEntitiesByUserIdAsync(string id)
        {
            var chats = await _uow.ChatsRepository.GetChatsByUserId(id);

            var dtos = _mapper.Map<List<Chat>, List<ChatDto>>(chats);

            return dtos;
        }

        public async Task<IEnumerable<UserDto>> GetUsersByChatIdAsync(int id)
        {
            var users = await _uow.ChatsRepository.GetUsersByChatId(id);

            var dtos = _mapper.Map<List<User>, List<UserDto>>(users);

            return dtos;
        }

        public async Task<UserDto> AddUserToChat(int chatId, string userId)
        {
            User user = await _uow.UsersRepository.GetFirstOrDefaultAsync(u => u.Id == userId);
            Chat chat = await _uow.ChatsRepository.GetFirstOrDefaultAsync(c => c.Id == chatId);

            if (user == null || chat == null) return null;

            UserChat userChat = await _uow.ChatsRepository.AddUserChat(new UserChat() { ChatId = chatId, UserId = userId });

            await _uow.SaveAsync();

            UserDto userDto = _mapper.Map<User, UserDto>(userChat.User);

            return userDto;
        }

        public async Task<ChatDto> GetEntityByIdAsync(int id)
        {
            var sample = await _uow.ChatsRepository.GetFirstOrDefaultAsync(s => s.Id == id,
                include: chats => chats.Include(c => c.CreatedBy)
                                                        .Include(c => c.Messages)
                                                        .Include(c => c.Organization)
                                                        .Include(c => c.UserChats));

            if (sample == null) return null;

            var dto = _mapper.Map<Chat, ChatDto>(sample);

            return dto;
        }

        public async Task<ChatDto> CreateEntityAsync(ChatRequest request)
        {
            var entity = _mapper.Map<ChatRequest, Chat>(request);

            entity = await _uow.ChatsRepository.CreateAsync(entity);

            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Chat, ChatDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(ChatUpdateRequest request, int id)
        {
            var entity = _mapper.Map<ChatUpdateRequest, Chat>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.ChatsRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            await _uow.ChatsRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
