using ANK_9.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ANK_9.DAL.Base.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        private readonly TContext context;

        public EFRepositoryBase(TContext context)
        {
            this.context = context;
        }

        public TEntity Add(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Added;
            return context.SaveChanges() > 0 ? entity : null;
        }

        public TEntity Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0 ? entity : null;
        }

        public void Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            var result = context.Set<TEntity>()
                                .Where(filter)
                                .MyInclude(includes)
                                .FirstOrDefault();
            return result;
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includes)
        {
            var result = context.Set<TEntity>();

            return filter == null ?
                 result.MyInclude(includes) :

                 result.Where(filter)
                 .MyInclude(includes);
        }
    }
}
