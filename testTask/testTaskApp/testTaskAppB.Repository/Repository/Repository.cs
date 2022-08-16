using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace testTaskAppB.Repository.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly InternalDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(InternalDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? predicate = null)
    {
        return predicate != null ? await _dbSet.Where(predicate).ToListAsync() : await _dbSet.ToListAsync();
    }
}