using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace Watcher.DataAccess.Interfaces.Repositories
{
    using Watcher.DataAccess.Entities;

    public interface IUserOrganizationRepository
    {
        Task<UserOrganization> CreateAsync(UserOrganization entity);

        void Delete(int companyId, string userId);

        Task<List<UserOrganization>> GetRangeAsync(Func<IQueryable<UserOrganization>, IIncludableQueryable<UserOrganization, object>> include = null, bool disableTracking = true);
    }
}