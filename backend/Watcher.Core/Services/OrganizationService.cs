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
                .Include(o => o.Notifications)
                .Include(o => o.Instances)
                .Include(o => o.UserOrganizations));

            var dtos = _mapper.Map<List<Organization>, List<OrganizationDto>>(entities);

            return dtos;
        }

        public async Task<OrganizationDto> GetEntityByIdAsync(int id)
        {
            var entity = await _uow.OrganizationRepository
                .GetFirstOrDefaultAsync(
                    predicate: o => o.Id == id, 
                    include: x => x
                        .Include(o => o.Theme)
                        .Include(o => o.Notifications)
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
                CreatedEntity.UserOrganizations.Add(new UserOrganization
                {
                    UserId = entity.CreatedByUserId,
                    OrganizationId = entity.Id
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

 /*
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
            await _uow.OrganizationRepository.DeleteAsync(id);

            var result = await _uow.SaveAsync();

            return result;
        }
    }
}
