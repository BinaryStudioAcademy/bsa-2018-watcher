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
    public class ResponseService : IResponseService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ResponseService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ResponseDto>> GetAllEntitiesAsync()
        {
            var entities = await _uow.ResponseRepository.GetRangeAsync(include: x => x
                .Include(o => o.User)
                .Include(o => o.Feedback));

            var dtos = _mapper.Map<List<Response>, List<ResponseDto>>(entities);

            return dtos;
        }

        public async Task<ResponseDto> GetEntityByIdAsync(int id)
        {
            var entity = await _uow.ResponseRepository
                .GetFirstOrDefaultAsync(
                    predicate: o => o.Id == id,
                    include: x => x
                        .Include(o => o.User)
                        .Include(o => o.Feedback));

            if (entity == null) return null;

            var dto = _mapper.Map<Response, ResponseDto>(entity);

            return dto;
        }

        public async Task<ResponseDto> CreateEntityAsync(ResponseRequest request)
        {
            var entity = _mapper.Map<ResponseRequest, Response>(request);

            entity = await _uow.ResponseRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Response, ResponseDto>(entity);

            return dto;
        }
    }
}
