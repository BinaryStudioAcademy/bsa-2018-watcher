namespace Watcher.Core.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.Common.Enums;

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
            var chats = await _uow.ChatsRepository.GetRangeAsync(
                include: c => c.Include(x => x.UserChats)
                               .ThenInclude(x => x.User));

            var dtos = _mapper.Map<List<Chat>, List<ChatDto>>(chats);

            return dtos;
        }

        public async Task<ChatDto> GetEntityByIdAsync(int id)
        {
            var chat = await _uow.ChatsRepository.GetFirstOrDefaultAsync(s => s.Id == id,
                                include: chats => chats.Include(c => c.CreatedBy)
                                                        .Include(c => c.Messages)
                                                            .ThenInclude(c => c.User)
                                                        .Include(c => c.Organization)
                                                        .Include(c => c.CreatedBy)
                                                        .Include(c => c.UserChats)
                                                            .ThenInclude(uc => uc.User));

            if (chat == null) return null;

            var dto = _mapper.Map<Chat, ChatDto>(chat);

            return dto;
        }

        public async Task<IEnumerable<ChatDto>> GetEntitiesByUserIdAsync(string id)
        {
            var chats = await _uow.ChatsRepository.GetChatsByUserId(id);
            var dtos = _mapper.Map<List<Chat>, List<ChatDto>>(chats,
                opts: o => o.AfterMap((src, dest) => dest
                    .ForEach(c =>
                    {
                        c.UnreadMessagesCount = CountUnreadedMessagesForUser(id, c.Messages);
                        c.Messages = null;
                    })));

            return dtos;
        }

        public async Task<IEnumerable<UserDto>> GetUsersByChatIdAsync(int id)
        {
            var users = await _uow.ChatsRepository.GetUsersByChatId(id);

            var dtos = _mapper.Map<List<User>, List<UserDto>>(users);

            return dtos;
        }

        public async Task<bool> AddUserToChat(int chatId, string userId)
        {
            var userChat = await _uow.ChatsRepository.AddUserChat(new UserChat() { ChatId = chatId, UserId = userId });

            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteUserFromChat(int chatId, string userId)
        {
            await _uow.ChatsRepository.DeleteUserChat(new UserChat() { ChatId = chatId, UserId = userId });

            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<ChatDto> CreateEntityAsync(ChatRequest request)
        {
            var entity = _mapper.Map<ChatRequest, Chat>(request);

            if (entity.Type == ChatType.BetweenUsers)
            {
                entity.UserChats.Add(new UserChat
                {
                    UserId = entity.CreatedById,
                    Chat = entity
                });

                foreach (var user in request.Users)
                {
                    entity.UserChats.Add(new UserChat
                    {
                        UserId = user.Id,
                        Chat = entity
                    });
                }
            }

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
            await _uow.ChatsRepository.DeleteAsync(id, 
                include: chat => chat.Include(c => c.Messages));

            var result = await _uow.SaveAsync();

            return result;
        }

        private int CountUnreadedMessagesForUser(string userId, IList<MessageDto> messages)
        {
            return messages.Count(m => !m.WasRead && m.User.Id != userId);
        }
    }
}
