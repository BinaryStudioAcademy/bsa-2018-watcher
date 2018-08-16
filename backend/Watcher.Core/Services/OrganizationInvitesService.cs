
namespace Watcher.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Security.Cryptography;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;
    using System.Text;
    using System;
    using Watcher.Common.Enums;

    public class OrganizationInvitesService: IOrganizationInvitesService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public OrganizationInvitesService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<OrganizationInviteDto> GetEntityByLinkAsync(string link)
        {
            var entity = await _uow.OrganizationInvitesRepository
                .GetFirstOrDefaultAsync(
                    predicate: o => o.Link == link,
                    include: x => x
                        .Include(o => o.CreatedByUser)
                        .Include(o => o.Organization));

            if (entity == null) return null;

            var dto = _mapper.Map<OrganizationInvite, OrganizationInviteDto>(entity);

            return dto;
        }

        public async Task<OrganizationInviteDto> CreateEntityAsync(OrganizationInviteRequest request)
        {
            var entity = _mapper.Map<OrganizationInviteRequest, OrganizationInvite>(request);
            entity.CreatedDate = DateTime.Now;
            entity.ExperationDate = entity.CreatedDate.AddDays(20); // TODO get from config Experation Days
            entity.Link = GetHashString(entity.Id + entity.CreatedByUserId + entity.CreatedDate);
            entity.State = OrganizationInviteState.Pending;

            entity = await _uow.OrganizationInvitesRepository.CreateAsync(entity);
            var result = await _uow.SaveAsync();
            if (!result)
            {
                return null;
            }

            if (entity == null) return null;

            // TODO If Email != "" Send Email

            var dto = _mapper.Map<OrganizationInvite, OrganizationInviteDto>(entity);

            return dto;
        }


        public async Task<bool> UpdateEntityByIdAsync(OrganizationInviteRequest request, int id)
        {
            var entity = _mapper.Map<OrganizationInviteRequest, OrganizationInvite>(request);
            entity.Id = id;

            // In returns updated entity, you could do smth with it or just leave as it is
            var updated = await _uow.OrganizationInvitesRepository.UpdateAsync(entity);
            var result = await _uow.SaveAsync();

            return result;
        }

        private string GetHashString(string inputString)
        {
            HashAlgorithm algorithm = MD5.Create();  //or use SHA256.Create();
            var bytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));

            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }



    }
}
