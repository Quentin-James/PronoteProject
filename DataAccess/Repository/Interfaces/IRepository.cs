namespace Models.Repository.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetListAsync();

    Task<T?> GetByIdAsync(int id);

    Task<T?> PostAsync(T entity);

    Task<T?> UpdateByIdAsync(int id, T entity);

    Task<bool> DeleteAsync(int id);

    IQueryable<T> Find(Expression<Func<T, bool>>? predicate = null,
        Expression<Func<T, IProperty>>? navigationPropertyPath = null,
        bool asNoTracking = true);
}