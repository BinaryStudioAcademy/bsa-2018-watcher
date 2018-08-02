namespace Watcher.DataAccess.Interfaces.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore.Query;

    using Watcher.Common.Interfaces.Entities;

    public interface IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task CreateManyAsync(ICollection<TEntity> items);
        void Delete(TEntity entityToDelete);
        Task DeleteAsync(TKey id);
        Task DeleteAsync(TKey id, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include);

        Task DeleteManyAsync(Expression<Func<TEntity, bool>> predicate = null,
                             Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
        Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate = null,
                                             Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                             Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
                                             bool disableTracking = true);

        Task<List<TEntity>> GetRangeAsync(int index = 1,
                                          int count = 10,
                                          Expression<Func<TEntity, bool>> filter = null,
                                          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                                          Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
                                          bool disableTracking = true);

        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity,
                                  Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

        TEntity Update(TEntity entity);
    }
}
