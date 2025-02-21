﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Models.Models;
using Models.Repository;

///<summary>
///StudentsRepository call the method of Repository
//<summary/>

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
    }
}