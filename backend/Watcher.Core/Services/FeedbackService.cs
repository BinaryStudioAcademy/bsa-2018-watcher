using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.Core.Interfaces;
using Watcher.DataAccess.Entities;
using Watcher.DataAccess.Interfaces;

namespace Watcher.Core.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public FeedbackService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FeedbackDto>> GetAllEntitiesAsync()
        {
            var entities = await _uow.FeedbackRepository.GetRangeAsync(1, 30, include: x => x
                .Include(o => o.User)
                .Include(o => o.Response));

            var dtos = _mapper.Map<List<Feedback>, List<FeedbackDto>>(entities);

            return dtos;
        }

        public async Task<IEnumerable<FeedbackDto>> GetRangeOfEntitiesAsync(int page, int pageSize)
        {
            var entities = await _uow.FeedbackRepository.GetRangeAsync(include: x => x
                .Include(o => o.User)
                .Include(o => o.Response), index: page, count: pageSize);

            var dtos = _mapper.Map<List<Feedback>, List<FeedbackDto>>(entities);

            return dtos;
        }

        public async Task<int> GetNumberOfEntitiesAsync()
        {
            var entities = await _uow.FeedbackRepository.CountAsync(o => o.Id >= 0);

            return entities;
        }

        public async Task<FeedbackDto> GetEntityByIdAsync(int id)
        {
            var entity = await _uow.FeedbackRepository
                .GetFirstOrDefaultAsync(
                    predicate: o => o.Id == id,
                    include: x => x
                        .Include(o => o.User)
                        .Include(o => o.Response));

            if (entity == null) return null;

            var dto = _mapper.Map<Feedback, FeedbackDto>(entity);

            return dto;
        }

        public async Task<FeedbackDto> CreateEntityAsync(FeedbackRequest request)
        {
            var entity = _mapper.Map<FeedbackRequest, Feedback>(request);

            entity = await _uow.FeedbackRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Feedback, FeedbackDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(FeedbackDto request, int id)
        {
            var entity = _mapper.Map<FeedbackDto, Feedback>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.FeedbackRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            await _uow.FeedbackRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
