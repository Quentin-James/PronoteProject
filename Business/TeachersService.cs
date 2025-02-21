using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models;

namespace Business
{
    internal class TeachersService : IServiceTeachers
    {
        private readonly IRepositoryTeachers _repositoryTeachers;

        public TeachersService(IRepositoryTeachers repositoryTeachers)
        {
            _repositoryTeachers = repositoryTeachers;
        }

        public async Task<Teacher?> GetByIdAsync(int id)
        {
            return await _repositoryTeachers.GetByIdAsync(id);
        }

        public async Task<Teacher?> PostAsync(Teacher entity)
        {
            return await _repositoryTeachers.PostAsync(entity);
        }

        public async Task<Teacher?> UpdateByIdAsync(int id, Teacher entity)
        {
            return await _repositoryTeachers.UpdateByIdAsync(id, entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repositoryTeachers.DeleteAsync(id);
        }

        public IQueryable<Teacher> FindAsync(Expression<Func<Teacher, bool>>? predicate = null, Expression<Func<Teacher, IProperty>>? navigationPropertyPath = null, bool asNoTracking = true)
        {
            return _repositoryTeachers.FindAsync(predicate, navigationPropertyPath, asNoTracking);
        }
    }
}