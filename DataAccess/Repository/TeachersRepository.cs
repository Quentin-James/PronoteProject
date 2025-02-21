using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Models.Models;
using Models.Repository;

namespace DataAccess.Repository
{
    internal class TeachersRepository : Repository<Teacher>, IRepositoryTeachers
    {
<<<<<<< HEAD
        public TeachersRepository(DbContext context) : base(context)
        {
=======
        private readonly DbContext _context;
        private readonly DbSet<Teacher> _dbSet;

        public TeachersRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<Teacher>();
        }

        public async Task<Teacher?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<Teacher?> UpdateByIdAsync(int id, Student entity)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<Teacher?> PostAsync(Teacher entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
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
>>>>>>> 5045249 ( Correctif sur les repo Student, + push repo Teachers)
        }
    }
}