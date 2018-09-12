using AutoMapper;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.Core.Interfaces;
using Watcher.DataAccess.Entities;
using Watcher.DataAccess.Interfaces;
namespace Watcher.Core.Services
{
    public class ThemeService : IThemeService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ThemeService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ThemeDto>> GetAllEntitiesAsync()
        {
            var entities = await _uow.ThemeRepository.GetRangeAsync();

            if (entities == null) return null;
            var dtos = _mapper.Map<List<Theme>, List<ThemeDto>>(entities);

            return dtos;
        }

        public async Task<ThemeDto> CreateEntityAsync(ThemeDto themeDto)
        {
            var entity = _mapper.Map<ThemeDto, Theme>(themeDto);

            entity = await _uow.ThemeRepository.CreateAsync(entity);

            var result = await _uow.SaveAsync();
            if(!result || entity == null)
            {
                return null;
            }

            var dto = _mapper.Map<Theme, ThemeDto>(entity);

            return dto;

        }
    }
}
