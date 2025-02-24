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
    public DbSet<Absence> Absences => this.Set<Absence>();

    /// <summary>
    /// DbSet for courses.
    /// </summary>
    public DbSet<Course> Courses => this.Set<Course>();

    /// <summary>
    /// DbSet for parents.
    /// </summary>
    public DbSet<Parent> Parents => this.Set<Parent>();

    /// <summary>
    /// DbSet for schools.
    /// </summary>
    public DbSet<School> Schools => this.Set<School>();

    /// <summary>
    /// DbSet for students.
    /// </summary>
    public DbSet<Student> Students => this.Set<Student>();

    /// <summary>
    /// DbSet for subjects.
    /// </summary>
    public DbSet<Subject> Subjects => this.Set<Subject>();

    /// <summary>
    /// DbSet for teachers.
    /// </summary>
    public DbSet<Teacher> Teachers => this.Set<Teacher>();

    /// <summary>
    /// DbSet for grades.
    /// </summary>
    public DbSet<Grade> Grades => this.Set<Grade>();

    /// <summary>
    /// DbSet for classes.
    /// </summary>
    public DbSet<Classe> Classes => this.Set<Classe>();

    /// <summary>
    /// DbSet for classrooms.
    /// </summary>
    public DbSet<Classroom> Classrooms => this.Set<Classroom>();

    /// <summary>
    /// DbSet for student-parent relationships.
    /// </summary>
    public DbSet<StudentParent> StudentParents => this.Set<StudentParent>();
}