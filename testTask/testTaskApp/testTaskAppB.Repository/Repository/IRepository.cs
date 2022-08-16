using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace testTaskAppB.Repository.Repository
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? predicate = null);
    }
}
