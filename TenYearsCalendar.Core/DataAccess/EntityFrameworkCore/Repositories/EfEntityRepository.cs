using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TenYearsCalendar.Core.DataAccess.Interfaces;
using TenYearsCalendar.Core.Entities.Abstract;

namespace TenYearsCalendar.Core.DataAccess.EntityFrameworkCore.Repositories
{
    public class EfEntityRepository<TEntity> : IEntityRepositoryBase<TEntity> where TEntity : class, IEntity, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using var context = new Context();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(List<TEntity> entities)
        {
            using var context = new Context();
            await context.AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using var context = new Context();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new Context();
            return await context.Set<TEntity>().Where(filter).FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new Context();
            if (filter==null)
            {
                return await context.Set<TEntity>().ToListAsync();
            }
            return await context.Set<TEntity>().Where(filter).ToListAsync();

        }

        public async Task UpdateAsync(TEntity entity)
        {
            using var context = new Context();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
