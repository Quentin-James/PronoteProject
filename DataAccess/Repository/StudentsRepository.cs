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

///<summary>
///StudentsRepository call the method of Repository
//<summary/>

namespace DataAccess.Repository
{
    internal class StudentsRepository(DbContext context) : Repository<Student>(context), IRepositoryStudents
    {
    }
}