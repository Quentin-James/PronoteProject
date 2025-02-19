namespace DataAccess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

public interface IDbDataAccess
{
    DbSet<Absence> Absences { get; set; }
    DbSet<Course> Courses { get; set; }
    DbSet<Parent> Parents { get; set; }
    DbSet<School> Schools { get; set; }
    DbSet<Student> Students { get; set; }
    DbSet<Subject> Subjects { get; set; }
    DbSet<Teacher> Teachers { get; set; }
    DbSet<Grade> Grades { get; set; }
    DbSet<Classe> Classes { get; set; }
    DbSet<Classroom> Classrooms { get; set; }
    DbSet<StudentParent> StudentParents { get; set; }
    DbSet<User> Users { get; set; }
}