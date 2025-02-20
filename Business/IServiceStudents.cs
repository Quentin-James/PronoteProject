using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models;

namespace Business
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

