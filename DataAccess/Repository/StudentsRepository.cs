using DataAccess.Repository.Interfaces;
using Models.Models;
using Models.Repository;

///<summary>
///StudentsRepository call the method of Repository
//<summary/>

namespace DataAccess.Repository
{
    internal class StudentsRepository(DbDataAccess context) : Repository<Student>(context), IRepositoryStudents
    {
    }
}