using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Models.Models;
using Models.Repository.Interfaces;

namespace DataAccess.Repository.Interfaces
{
    public interface IRepositoryTeachers : IRepository<Teacher>
    {
    }
}