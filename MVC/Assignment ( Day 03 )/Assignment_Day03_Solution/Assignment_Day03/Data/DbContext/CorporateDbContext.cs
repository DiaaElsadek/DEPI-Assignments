using Assignment_Day03.Models;
using Assignment_Day03.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MVC_G01.Data.DbContexts
{
    public class CorporateDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Corporate03;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StuCrsRes>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<StuCrsRes>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.StuCrsRes)
                .HasForeignKey(sc => sc.StudentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<StuCrsRes>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(c => c.StuCrsRes)
                .HasForeignKey(sc => sc.CourseId).OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StuCrsRes> StuCrsRes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
