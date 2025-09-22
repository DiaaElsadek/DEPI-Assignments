using Assignment_Day02.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Assignment_Day02.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<StuCrsRes> StuCrsRes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite Key for StuCrsRes
        modelBuilder.Entity<StuCrsRes>()
            .HasKey(s => new { s.StudentId, s.CourseId });

        base.OnModelCreating(modelBuilder);
    }
}
