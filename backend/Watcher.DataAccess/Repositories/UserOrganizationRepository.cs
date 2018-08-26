using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

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
            return await query.ToListAsync();
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
    }
}
