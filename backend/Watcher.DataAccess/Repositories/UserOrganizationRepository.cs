namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Query;

    using Watcher.Common.Interfaces.Entities;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;
    using Watcher.Common.Errors;
    using System.Net;

    public class UserOrganizationRepository : IUserOrganizationRepository
    {
        protected readonly WatcherDbContext Context;
        protected readonly DbSet<UserOrganization> DbSet;

        protected readonly IMapper mapper;

        public UserOrganizationRepository(WatcherDbContext context, IMapper automapper)
        {
            Context = context;
            DbSet = Context.Set<UserOrganization>();
            mapper = automapper;
        }

        public async Task<UserOrganization> CreateAsync(UserOrganization entity)
        {
            await DbSet.AddAsync(entity);

            return entity;
        }

        public async Task<List<UserOrganization>> GetRangeAsync(Func<IQueryable<UserOrganization>, IIncludableQueryable<UserOrganization, object>> include = null, bool disableTracking = true)
        {
            IQueryable<UserOrganization> query = DbSet;

            if (include != null)
            {
                query = include(query);
            }
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }
            var items = await query.ToListAsync();

            if (items is IEnumerable<ISoftDeletable>)
            {
                items = items.Where(i => ((ISoftDeletable)i).IsDeleted == false).ToList();
            }

            return items;
        }

        public void Delete(int companyId, string userId)
        {
            IQueryable<UserOrganization> query = DbSet.Include(c => c.User).Include(c => c.Organization);
            
            var entityToDelete = query.FirstOrDefault(e => e.OrganizationId == companyId && e.UserId == userId);
           
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }

            DbSet.Remove(entityToDelete);
        }

        public async Task<UserOrganization> UpdateAsync(UserOrganization userOrganization)
        {
            var findEntity = await DbSet.FindAsync(userOrganization.OrganizationId, userOrganization.UserId);

            if (findEntity == null)
            {
                throw new HttpStatusCodeException(HttpStatusCode.NotFound, $"Entity {userOrganization.GetType().Name} not found");
            }

            findEntity.OrganizationRoleId = userOrganization.OrganizationRoleId;

            return findEntity;
        }

        public async Task<List<UserOrganization>> GetAllByOrganizationId(int id)
        {
            IQueryable<UserOrganization> query = DbSet.Include(c => c.User)
                                                      .Include(c => c.Organization)
                                                      .Include(c => c.OrganizationRole)
                                                      .Where(c => c.OrganizationId == id);
            return await query.ToListAsync();
        }
    }
}
