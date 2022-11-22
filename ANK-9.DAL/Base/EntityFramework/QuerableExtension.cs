using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ANK_9.DAL.Base.EntityFramework
{
    public static class QuerableExtension
    {
        public static IQueryable<T> MyInclude<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes)
            where T : class
        {
            if (includes != null)
            {
                query = includes.Aggregate(query, (a, b) => a.Include(b));
            }

            return query;
        }

    }
}
