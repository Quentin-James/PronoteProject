using System.Linq.Expressions;
using Business.Interfaces;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models;

namespace Business
{
    internal class TeachersService(IRepositoryTeachers repositoryTeachers) : IServiceTeachers
    {
        public async Task<Teacher?> GetByIdAsync(int id)
        {
            return await repositoryTeachers.GetByIdAsync(id).ConfigureAwait(false);
        }

        public async Task<Teacher?> PostAsync(Teacher entity)
        {
            return await repositoryTeachers.PostAsync(entity).ConfigureAwait(false);
        }

        public async Task<Teacher?> UpdateByIdAsync(int id, Teacher entity)
        {
            return await repositoryTeachers.UpdateByIdAsync(id, entity).ConfigureAwait(false);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await repositoryTeachers.DeleteAsync(id).ConfigureAwait(false);
        }

        public IQueryable<Teacher> FindAsync(Expression<Func<Teacher, bool>>? predicate = null, Expression<Func<Teacher, IProperty>>? navigationPropertyPath = null, bool asNoTracking = true)
        {
            return repositoryTeachers.FindAsync(predicate, navigationPropertyPath, asNoTracking);
        }
    }
}