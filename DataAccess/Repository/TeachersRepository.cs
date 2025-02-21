using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Models.Models;
using Models.Repository;

namespace DataAccess.Repository
{
    internal class TeachersRepository : Repository<Teacher>, IRepositoryTeachers
    {
        public TeachersRepository(DbContext context) : base(context)
        {
        }
    }
}