
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
        private readonly IEmailProvider _emailProvider;

        public OrganizationInvitesService(IUnitOfWork uow, IMapper mapper, IEmailProvider emailProvider)
        {
            _uow = uow;
            _mapper = mapper;
            _emailProvider = emailProvider;
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

            if (entity.State != OrganizationInviteState.Pending) return null;

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

            if (!result)return null;

            if (entity == null) return null;

            var dto = _mapper.Map<OrganizationInvite, OrganizationInviteDto>(entity);

            return dto;
        }


        public async Task<bool> UpdateEntityByIdAsync(OrganizationInviteRequest request, int id)
        {
            bool result = false;
            
            if (request.CreatedByUserId == request.InvitedUserId) return false;

            var entity = _mapper.Map<OrganizationInviteRequest, OrganizationInvite>(request);
            entity.Id = id;

            var inviteFromDb = await _uow.OrganizationInvitesRepository.GetFirstOrDefaultAsync(x => x.Id == entity.Id);
            if (inviteFromDb == null) return false;
            if (inviteFromDb.State != OrganizationInviteState.Pending) return false;

            if (entity.State == OrganizationInviteState.Accepted)
            {
                var invitedUser = await _uow.UsersRepository.GetFirstOrDefaultAsync(x => x.Id == entity.InvitedUserId);
                await _uow.BeginTransaction();

                if (invitedUser.UserOrganizations == null) invitedUser.UserOrganizations = new List<UserOrganization>();

                invitedUser.UserOrganizations.Add(new UserOrganization
                {
                    UserId = invitedUser.Id,
                    OrganizationId = entity.OrganizationId
                });

                await _uow.UsersRepository.UpdateAsync(invitedUser);

                var updated = await _uow.OrganizationInvitesRepository.UpdateAsync(entity);
                result = await _uow.SaveAsync();
                _uow.CommitTransaction();
            }
            else
            {
                if (entity.State == OrganizationInviteState.Pending)
                {
                    if (String.IsNullOrWhiteSpace(entity.InviteEmail) != true) // send Email
                    {
                        await _emailProvider.SendMessageOneToOne("5avel@hotmail.com", "Test Invite", entity.InviteEmail, "Test Body", "");
                    }
                }
                var updated = await _uow.OrganizationInvitesRepository.UpdateAsync(entity);
                result = await _uow.SaveAsync();
            }
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
