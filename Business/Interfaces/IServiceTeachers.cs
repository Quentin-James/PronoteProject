using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models;

namespace Business.Interfaces
{
    public interface IServiceTeachers
    {
        Task<Teacher?> GetByIdAsync(int id);

        Task<Teacher?> PostAsync(Teacher entity);

        Task<Teacher?> UpdateByIdAsync(int id, Teacher entity);

        Task<bool> DeleteAsync(int id);

        //IQueryable is for querying data from the database. It is a generic interface that takes a type parameter.
        //In this case, the type parameter is Teacher. The FindAsync method takes three parameters:
        //predicate, navigationPropertyPath, and asNoTracking. The predicate parameter is a lambda expression that
        //defines the condition for the query. The navigationPropertyPath parameter is an expression that specifies

        IQueryable<Teacher> FindAsync(Expression<Func<Teacher, bool>>? predicate = null,
            Expression<Func<Teacher, IProperty>>? navigationPropertyPath = null,
            bool asNoTracking = true);
    }
}