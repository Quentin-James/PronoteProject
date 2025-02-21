using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Repository.Interfaces;

///<summary>
///Create the generic method of the API
/// </summary>
namespace Models.Repository
{
    internal abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id).ConfigureAwait(false);
            if (entity == null)
            {
                return false;
            }

            _dbSet.Remove(entity);
            var result = await _context.SaveChangesAsync().ConfigureAwait(false);
            return result > 0;
        }

        public IQueryable<T> FindAsync(Expression<Func<T, bool>>? predicate = null,
            Expression<Func<T, IProperty>>? navigationPropertyPath = null,
            bool asNoTracking = true)
        {
            var query = _dbSet.AsQueryable();
            if (navigationPropertyPath != null)
            {
                query = query.Include(navigationPropertyPath);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return asNoTracking ? query.AsNoTracking() : query;
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id).ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> GetListAsync()
        {
            return await _dbSet.ToListAsync().ConfigureAwait(false);
        }

        public async Task<T?> PostAsync(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return entity;
        }

        public async Task<T?> UpdateByIdAsync(int id, T updatedEntity)
        {
            var entity = await _dbSet.FindAsync(id).ConfigureAwait(false);
            if (entity == null)
            {
                return null;
            }

            _context.Entry(entity).CurrentValues.SetValues(updatedEntity);
            _context.Entry(entity).State = EntityState.Modified;

            await _context.SaveChangesAsync().ConfigureAwait(false);
            return entity;
        }
    }
}