namespace DataAccess;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Models.Models;

/// <summary>
/// DbDataAccess class that inherits from IdentityDbContext to manage database operations.
/// </summary>
public class DbDataAccess(DbContextOptions<DbDataAccess> options) : IdentityDbContext<User, IdentityRole<int>, int>(options), IDbDataAccess
{
    /// <summary>
    /// Configures the data model using the .
    /// </summary>ModelBuilder
    /// <param name="modelBuilder">Instance of ModelBuilder used to configure the data model.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().ToTable("Users");
    }

    /// <summary>
    /// DbSet for absences.
    /// </summary>
    public DbSet<Absence> Absences { get; set; }

    /// <summary>
    /// DbSet for courses.
    /// </summary>
    public DbSet<Course> Courses { get; set; }

    /// <summary>
    /// DbSet for parents.
    /// </summary>
    public DbSet<Parent> Parents { get; set; }

    /// <summary>
    /// DbSet for schools.
    /// </summary>
    public DbSet<School> Schools { get; set; }

    /// <summary>
    /// DbSet for students.
    /// </summary>
    public DbSet<Student> Students { get; set; }

    /// <summary>
    /// DbSet for subjects.
    /// </summary>
    public DbSet<Subject> Subjects { get; set; }

    /// <summary>
    /// DbSet for teachers.
    /// </summary>
    public DbSet<Teacher> Teachers { get; set; }

    /// <summary>
    /// DbSet for grades.
    /// </summary>
    public DbSet<Grade> Grades { get; set; }

    /// <summary>
    /// DbSet for classes.
    /// </summary>
    public DbSet<Classe> Classes { get; set; }

    /// <summary>
    /// DbSet for classrooms.
    /// </summary>
    public DbSet<Classroom> Classrooms { get; set; }

    /// <summary>
    /// DbSet for student-parent relationships.
    /// </summary>
    public DbSet<StudentParent> StudentParents { get; set; }
}