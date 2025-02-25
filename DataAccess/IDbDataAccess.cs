namespace DataAccess;

using Microsoft.EntityFrameworkCore;
using Models.Models;

/// <summary>
/// Interface representing the data access to the database.
/// </summary>
public interface IDbDataAccess
{
    /// <summary>
    /// Data set for absences.
    /// </summary>
    DbSet<Absence> Absences { get; }

    /// <summary>
    /// Data set for courses.
    /// </summary>
    DbSet<Course> Courses { get; }

    /// <summary>
    /// Data set for parents.
    /// </summary>
    DbSet<Parent> Parents { get; }

    /// <summary>
    /// Data set for schools.
    /// </summary>
    DbSet<School> Schools { get; }

    /// <summary>
    /// Data set for students.
    /// </summary>
    DbSet<Student> Students { get; }

    /// <summary>
    /// Data set for subjects.
    /// </summary>
    DbSet<Subject> Subjects { get; }

    /// <summary>
    /// Data set for teachers.
    /// </summary>
    DbSet<Teacher> Teachers { get; }

    /// <summary>
    /// Data set for grades.
    /// </summary>
    DbSet<Grade> Grades { get; }

    /// <summary>
    /// Data set for classes.
    /// </summary>
    DbSet<Classe> Classes { get; }

    /// <summary>
    /// Data set for classrooms.
    /// </summary>
    DbSet<Classroom> Classrooms { get; }

    /// <summary>
    /// Data set for users.
    /// </summary>
    DbSet<User> Users { get; }
}