using DataAccess.Repository.Interfaces;
using Models.Models;
using Models.Repository;

namespace DataAccess.Repository;

internal class TeachersRepository(DbDataAccess context) : Repository<Teacher>(context), IRepositoryTeachers
{
}