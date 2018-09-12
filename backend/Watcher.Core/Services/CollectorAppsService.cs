namespace Watcher.Core.Services
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Security.Cryptography;
    using System.Linq;
    using AutoMapper;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Core.Hubs;
    using Watcher.Common.Enums;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;
    using Microsoft.AspNetCore.Http;

    public class CollectorAppsService : ICollectorAppsService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IEmailProvider _emailProvider;
        private readonly IFileStorageProvider _fileStorageProvider;
        public CollectorAppsService(IUnitOfWork uow,
                                    IMapper mapper,
                                    IEmailProvider emailProvider,
                                    IFileStorageProvider fileStorageProvider)
        {
            _uow = uow;
            _mapper = mapper;
            _emailProvider = emailProvider;
            _fileStorageProvider = fileStorageProvider;
        }

        public async Task<string> UploadFileToStorage(IFormFile file)
        {
            return await _fileStorageProvider.UploadFormFileWithNameAsync(file);
        }

        public async Task<List<CollectorAppVersionDto>> GetAllEntityesAsync()
        {
            var entities = await _uow.CollectorAppVersionRepository.GetRangeAsync(1, int.MaxValue);

            var dtos = _mapper.Map<List<CollectorAppVersion>, List<CollectorAppVersionDto>>(entities);

            return dtos;
        }

        public async Task<CollectorAppVersionDto> GetActiveEntityAsync()
        {
            var entity = await _uow.CollectorAppVersionRepository
                .GetFirstOrDefaultAsync(x => x.IsActive);

            if (entity == null) return null;

            var dto = _mapper.Map<CollectorAppVersion, CollectorAppVersionDto>(entity);

            return dto;
        }

        public async Task<CollectorAppVersionDto> CreateEntityAsync(CollectorAppVersionRequest request)
        {
            var entity = _mapper.Map<CollectorAppVersionRequest, CollectorAppVersion>(request);
            entity.CreatedAt = DateTime.Now;

            entity = await _uow.CollectorAppVersionRepository.CreateAsync(entity);

            if(entity != null && entity.IsActive)
            {
                var items = await _uow.CollectorAppVersionRepository
                    .GetRangeAsync(1, int.MaxValue, x => x.Id != entity.Id && x.IsActive);

                items.ForEach(x => {
                    x.IsActive = false;
                    _uow.CollectorAppVersionRepository.Update(x);
                });
            }

            var result = await _uow.SaveAsync();

            if (!result) return null;

            if (entity == null) return null;

            var dto = _mapper.Map<CollectorAppVersion, CollectorAppVersionDto>(entity);
            return dto;
        }

        public async Task<bool> DeleteEntityAsync(int id)
        {
            var entity = await _uow.CollectorAppVersionRepository.GetFirstOrDefaultAsync(i => i.Id == id);

            if (entity.IsActive) return false;

            await _uow.CollectorAppVersionRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            if(result)
            {
                await _fileStorageProvider.DeleteFileAsync(entity.ExeLink);
                await _fileStorageProvider.DeleteFileAsync(entity.DebLink);
                await _fileStorageProvider.DeleteFileAsync(entity.TgzLink);
            }

            return result;
        }

        public async Task<CollectorAppVersionDto> SetActualApp(int id)
        {
            var entity = await _uow.CollectorAppVersionRepository.GetFirstOrDefaultAsync(i => i.Id == id);

            if (entity.IsActive) return _mapper.Map<CollectorAppVersion, CollectorAppVersionDto>(entity);

            var items = await _uow.CollectorAppVersionRepository.
                GetRangeAsync(1, int.MaxValue, x => x.Id != id && x.IsActive);

                items.ForEach(x => {
                    x.IsActive = false;
                    _uow.CollectorAppVersionRepository.Update(x);
                    });


            entity.IsActive = true;
            await _uow.CollectorAppVersionRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();
            if(result)
            {
                return _mapper.Map<CollectorAppVersion, CollectorAppVersionDto>(entity);
            }

            return null;
        }
    }
}
