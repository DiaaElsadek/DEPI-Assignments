using System.Data.Common;
using Core.Models;
using Infrastructure.Data.ConfigurationClasses;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class TestCaseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TestCasee;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TaskConfiguration());
        }
    }
}
