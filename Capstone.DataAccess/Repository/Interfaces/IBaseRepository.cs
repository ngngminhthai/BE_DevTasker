using System.Linq.Expressions;

namespace Capstone.DataAccess.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAllAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>? pre);
        Task<IEnumerable<T>> GetAllWithOdata(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>? pre);
        Task<T>? GetAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>? pre);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        int SaveChanges();
    }
}
