using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Models.Models;
using Models.Repository;

<<<<<<< HEAD
///<summary>
///StudentsRepository call the method of Repository
//<summary/>

namespace DataAccess.Repository
{
    internal class StudentsRepository(DbContext context) : Repository<Student>(context), IRepositoryStudents
    {
=======
namespace DataAccess.Repository
{
    internal class StudentsRepository : Repository<Student>, IRepositoryStudents
    {
        private readonly DbContext _context;
        private readonly DbSet<Student> _dbSet;

        public StudentsRepository(DbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<Student>();
        }

        public async Task<IEnumerable<Student>> GetListAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<Student?> PostAsync(Student entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Student?> UpdateByIdAsync(int id, Student entity)
        {
            return await _dbSet.FindAsync(id);
        }
>>>>>>> 06c83f7 (Ajout Repo Student +genéricité avec injection de dépendance)
    }
}