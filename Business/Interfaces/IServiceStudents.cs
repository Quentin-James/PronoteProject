using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models;

namespace Business.Interfaces
{
    public interface IServiceStudents
    {
        Task<IEnumerable<Student>> GetListAsync();

        Task<Student?> GetByIdAsync(int id);

        Task<Student?> PostAsync(Student entity);

        Task<Student?> UpdateByIdAsync(int id, Student entity);

        Task<bool> DeleteAsync(int id);

        IQueryable<Student> FindAsync(Expression<Func<Student, bool>>? predicate = null,
            Expression<Func<Student, IProperty>>? navigationPropertyPath = null,
            bool asNoTracking = true);
    }
}