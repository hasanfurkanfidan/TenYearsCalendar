using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TenYearsCalendar.Core.Entities.Abstract;

namespace TenYearsCalendar.Core.DataAccess.Interfaces
{
    public interface IEntityRepositoryBase<TEntity> where TEntity:class,IEntity,new()
    {
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
        Task AddAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task AddRangeAsync(List<TEntity> entities);
    }
}
