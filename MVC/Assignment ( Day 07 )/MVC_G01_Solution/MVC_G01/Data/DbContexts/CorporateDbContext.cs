using Microsoft.EntityFrameworkCore;
using MVC_G01.Models;

namespace MVC_G01.Data.DbContexts
{
    public class CorporateDbContext : DbContext
    {
        // Buider Design Pattern
        // Build Complex object >> Constructor (inject)
        // Steps  >> Director (OnConfiguring)
        // Final Product DbContextOptions
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=Corporate02;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Corporate02;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

            // 1- activepageresultsets(self) , Encrypt , Trustservercertificate ......
            // 2- Extension Methods : 
            // Logging >> SQL ? >> Audit (Log) >> Performance , Security
            // Profiler >> Optimizes sql >> Engine >> Logging
            // .Log(Log Level) >> Output : Debug Window >> self
            // .Net 8.0 Migration (Encryption)
            // Navigate in Vs >> Sql server >> CS
            
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
