using Capstone.DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;

namespace Capstone.DataAccess.Repository.Implements
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        protected readonly CapstoneContext _context;
        public BaseRepository(CapstoneContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;
        }
        public async Task<T> CreateAsync(T entity)
        {
            var result = _dbSet.Add(entity).Entity;

            return await Task.FromResult(result);
        }
     
        public Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);

            return Task.FromResult(true);
        }

        public async Task<T>? GetAsync(Expression<Func<T, bool>>? predicate, Expression<Func<T, object>>? pre)
        {
            if (predicate == null)
            {
                return await _dbSet.FirstOrDefaultAsync();
            }
            else
            {
                if (pre != null)
                {
                    var result = await _dbSet.Include(pre).Where(predicate).FirstOrDefaultAsync();
                    return result;
                }
                else
                {
                    var result = await _dbSet.Where(predicate).FirstOrDefaultAsync();
                    return result;
                }
            }
            return await _dbSet.FirstOrDefaultAsync();
        }

        public IQueryable<T> GetAllAsync(Expression<Func<T, bool>>? predicate, Expression<Func<T, object>>? pre)
        {
            IQueryable<T> result;

            if (predicate == null)
            {
                result = _dbSet;
            }
            else
            {
                if (pre != null)
                {
                    result = _dbSet.Include(pre).Where(predicate);
                }
                else
                {
                    result = _dbSet.Where(predicate);
                }
            }

            return result.AsQueryable();
        }

        public async Task<IEnumerable<T>> GetAllWithOdata(Expression<Func<T, bool>>? predicate, Expression<Func<T, object>>? pre)
        {
            return await GetAllAsync(predicate, pre).ToListAsync();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate)
        {
            return predicate == null ? _dbSet : _dbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var result = _dbSet.Update(entity).Entity;

            return await Task.FromResult(result);
        }
    }
}
