using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.Shared.Exceptions;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.BusinessLayer.Services
{
    public class InstanceSettingsService : IInstanceSettingsService<InstanceSettingsDto>
    {
        private readonly IMapper _mapper;
        private readonly IInstanceSettingsRepository<InstanceSettings> _repository;

        public InstanceSettingsService(IMapper mapper, IInstanceSettingsRepository<InstanceSettings> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IEnumerable<InstanceSettingsDto>> GetEntitiesAsync()
        {
            var entities = await _repository.GetAllEntitiesAsync();
            if (entities == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<IEnumerable<InstanceSettings>, IEnumerable<InstanceSettingsDto>>(entities);
        }

        public async Task<InstanceSettingsDto> GetEntityAsync(Guid id)
        {
            var entity = await _repository.GetEntityAsync(id);
            if (entity == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<InstanceSettings, InstanceSettingsDto>(entity);
        }

        public async Task<InstanceSettingsDto> GetEntityByInstanceIdAsync(Guid clientId)
        {
            var entity = await _repository.GetEntityByInstanceIdAsync(clientId);
            if (entity == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<InstanceSettings, InstanceSettingsDto>(entity);
        }

        public async Task<InstanceSettingsDto> AddEntityAsync(InstanceSettingsDto dataDto)
        {
            if (dataDto?.Id == Guid.Empty)
            {
                dataDto.Id = Guid.NewGuid();
            }

            var mappedEntity = _mapper.Map<InstanceSettingsDto, InstanceSettings>(dataDto);
            await _repository.AddEntityAsync(mappedEntity);

            return dataDto;
        }

        public async Task<InstanceSettingsDto> UpdateEntityAsync(InstanceSettingsDto dataDto)
        {
            var entity = await _repository.GetEntityAsync(dataDto.Id);
            if (entity == null)
            {
                throw new NotFoundException();
            }

            var mappedEntity = _mapper.Map<InstanceSettingsDto, InstanceSettings>(dataDto);
            mappedEntity.InternalId = entity.InternalId;
            await _repository.UpdateEntityAsync(mappedEntity);

            return dataDto;
        }

        public async Task<bool> DeleteEntityAsync(Guid id)
        {
            if (!await _repository.EntityExistsAsync(id))
            {
                throw new NotFoundException();
            }

            return await _repository.RemoveEntityAsync(id);
        }
    }
}
