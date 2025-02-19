namespace DataAccess;

using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

public class DbDataAccess(DbContextOptions<DbDataAccess> options) : IdentityDbContext<User, IdentityRole<int>, int>(options), IDbDataAccess
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().ToTable("User");
        //                //modelBuilder.Entity<Classe>()
        //                //    .HasOne(c => c.Schools)
        //                //    .WithMany(e => e.Classes)
        //                //    .HasForeignKey(c => c.Id_school);

        //modelBuilder.Entity<Teacher>()
        //    .HasOne(p => p.Users)
        //    .WithMany(u => u.Teachers)
        //    .HasForeignKey(p => p.Id_user);

        //                //modelBuilder.Entity<Teacher>()
        //                //    .HasOne(p => p.Schools)
        //                //    .WithMany(e => e.Teachers)
        //                //    .HasForeignKey(p => p.Id_school);

        //                //modelBuilder.Entity<Teacher>()
        //                //    .HasOne(p => p.Subjects)
        //                //    .WithMany(m => m.Teachers)
        //                //    .HasForeignKey(p => p.Id_subject);

        //                //modelBuilder.Entity<Course>()
        //                //    .HasOne(c => c.Classes)
        //                //    .WithMany(cl => cl.Courses)
        //                //    .HasForeignKey(c => c.Id_classe);

        //                //modelBuilder.Entity<Course>()
        //                //    .HasOne(c => c.Classrooms)
        //                //    .WithMany(s => s.Courses)
        //                //    .HasForeignKey(c => c.Id_classroom);

        //                //modelBuilder.Entity<Course>()
        //                //    .HasOne(c => c.Teachers)
        //                //    .WithMany(p => p.Courses)
        //                //    .HasForeignKey(c => c.Id_teacher);

        //modelBuilder.Entity<Absence>()
        //    .HasOne(a => a.Users)
        //    .WithMany(u => u.Absences)
        //    .HasForeignKey(a => a.Id_user);

        //modelBuilder.Entity<Parent>()
        //    .HasOne(a => a.Users)
        //    .WithMany(u => u.Parents)
        //    .HasForeignKey(a => a.Id_user);

        //modelBuilder.Entity<Student>()
        //    .HasOne(e => e.Users)
        //    .WithMany(u => u.Students)
        //    .HasForeignKey(e => e.Id_user);

        //                //modelBuilder.Entity<Student>()
        //                //    .HasOne(e => e.Classes)
        //                //    .WithMany(c => c.Students)
        //                //    .HasForeignKey(e => e.Id_classe);

        //                //modelBuilder.Entity<Grade>()
        //                //    .HasOne(n => n.Subjects)
        //                //    .WithMany(m => m.Grades)
        //                //    .HasForeignKey(n => n.Id_subject);

        //                //modelBuilder.Entity<Grade>()
        //                //    .HasOne(n => n.Students)
        //                //    .WithMany(e => e.Grades)
        //                //    .HasForeignKey(n => n.Id_student);

        //                //modelBuilder.Entity<Asso>()
        //                //    .HasKey(a => new { a.Id_student, a.Id_parent });

        //                //modelBuilder.Entity<Asso>()
        //                //    .HasOne(a => a.Students)
        //                //    .WithMany(e => e.Assos)
        //                //    .HasForeignKey(a => a.Id_student);

        //                //modelBuilder.Entity<Asso>()
        //                //    .HasOne(a => a.Parents)
        //                //    .WithMany(p => p.Assos)
        //                //    .HasForeignKey(a => a.Id_parent);
    }

    public DbSet<Absence> Absences { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Parent> Parents { get; set; }
    public DbSet<School> Schools { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Classe> Classes { get; set; }
    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<StudentParent> StudentParents { get; set; }
}