using Microsoft.EntityFrameworkCore;

namespace Watcher.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;

    public class OrganizationService : IOrganizationService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IFileStorageProvider _fileStorageProvider;

        public OrganizationService(IUnitOfWork uow, IMapper mapper, IFileStorageProvider fileStorageProvider)
        {
            _uow = uow;
            _mapper = mapper;
            _fileStorageProvider = fileStorageProvider;
        }

        public async Task<IEnumerable<OrganizationDto>> GetAllEntitiesAsync()
        {
            var entities = await _uow.OrganizationRepository.GetRangeAsync(include: x => x
                .Include(o => o.Theme)
                .Include(o => o.Instances)
                .Include(o => o.UserOrganizations),
                count: await _uow.OrganizationRepository.CountAsync(o => o.Id >= 0));

            var dtos = _mapper.Map<List<Organization>, List<OrganizationDto>>(entities);

            return dtos;
        }

        public async Task<IEnumerable<OrganizationDto>> GetRangeOfEntitiesAsync(int page, int pageSize)
        {
            var entities = await _uow.OrganizationRepository.GetRangeAsync(include: x => x
                .Include(o => o.Theme)
                .Include(o => o.Instances)
                .Include(o => o.UserOrganizations), index: page, count: pageSize);

            var dtos = _mapper.Map<List<Organization>, List<OrganizationDto>>(entities);

            return dtos;
        }

        public async Task<int> GetNumberOfEntitiesAsync()
        {
            var entities = await _uow.OrganizationRepository.CountAsync(o => o.Id >= 0);

            return entities;
        }

        public async Task<OrganizationDto> GetEntityByIdAsync(int id)
        {
            var entity = await _uow.OrganizationRepository
                .GetFirstOrDefaultAsync(
                    predicate: o => o.Id == id,
                    include: x => x
                        .Include(o => o.Theme)
                        .Include(o => o.Instances)
                        .Include(o => o.UserOrganizations));

            if (entity == null) return null;

            var dto = _mapper.Map<Organization, OrganizationDto>(entity);

            return dto;
        }

        public async Task<OrganizationDto> CreateEntityAsync(OrganizationRequest request)
        {
            var entity = _mapper.Map<OrganizationRequest, Organization>(request);
            var result = false;

            var CreatedEntity = await _uow.OrganizationRepository.CreateAsync(entity);
            result = await _uow.SaveAsync();
            if (result)
            {
                //id 1 is for admin
                CreatedEntity.UserOrganizations.Add(new UserOrganization
                {
                    UserId = entity.CreatedByUserId,
                    OrganizationId = entity.Id,
                    OrganizationRoleId = 1,
                });
            }
            result &= await _uow.SaveAsync();

            var curentUser = await _uow.UsersRepository.GetFirstOrDefaultAsync(x => x.Id == CreatedEntity.CreatedByUserId,
                include: user => user.Include(x => x.UserOrganizations));

            curentUser.LastPickedOrganizationId = CreatedEntity.Id;
            curentUser.LastPickedOrganization = CreatedEntity;

            result &= await _uow.SaveAsync();

            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            var dto = _mapper.Map<Organization, OrganizationDto>(entity);

            return dto;
        }

        public async Task<bool> UpdateEntityByIdAsync(OrganizationUpdateRequest request, int id)
        {
            var entity = _mapper.Map<OrganizationUpdateRequest, Organization>(request);
            entity.Id = id;

            var existingEntity = await GetEntityByIdAsync(id);

            //var test = !existingEntity.ImageURL.Equals(entity.ImageURL);

            /* Here error when I updated organization.
            {System.NullReferenceException: Object reference not set to an instance of an object.
           at Watcher.Core.Providers.LocalFileStorageProvider.UploadFileBase64Async(String base64string, String imageType, String containerName) 
           in C:\Users\Eugene\Documents\GitHub\bsa-2018-watcher\backend\Watcher.Core\Providers\LocalFileStorageProvider.cs:line 100}


                       if (existingEntity.ImageURL != null && !existingEntity.ImageURL.Equals(entity.ImageURL))
                       {
                           await _fileStorageProvider.DeleteFileAsync(existingEntity.ImageURL);
                       }
                       entity.ImageURL = await _fileStorageProvider.UploadFileBase64Async(entity.ImageURL, request.ImageType); // TODO: change here for real image type
           */

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.OrganizationRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            await _uow.OrganizationRepository.DeleteAsync(id, include: org => 
                org.Include(o => o.Instances)
                    .ThenInclude(i => i.Dashboards)
                        .ThenInclude(d => d.Charts)
                .Include(o => o.OrganizationInvites));

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
