using System.Linq.Expressions;
using Business.Interfaces;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models;

namespace Business
{
    internal class StudentsServices(IRepositoryStudents repositoryStudents) : IServiceStudents
    {
        private readonly IRepositoryStudents _repositoryStudents = repositoryStudents;

        public async Task<IEnumerable<Student>> GetListAsync()
        {
            return await _repositoryStudents.GetListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _repositoryStudents.GetByIdAsync(id);
        }

        public async Task<Student?> PostAsync(Student entity)
        {
            return await _repositoryStudents.PostAsync(entity);
        }

        public async Task<Student?> UpdateByIdAsync(int id, Student entity)
        {
            return await _repositoryStudents.UpdateByIdAsync(id, entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repositoryStudents.DeleteAsync(id);
        }

        public IQueryable<Student> FindAsync(Expression<Func<Student, bool>>? predicate = null, Expression<Func<Student, IProperty>>? navigationPropertyPath = null, bool asNoTracking = true)
        {
            return _repositoryStudents.FindAsync(predicate, navigationPropertyPath, asNoTracking);
        }
    }
}