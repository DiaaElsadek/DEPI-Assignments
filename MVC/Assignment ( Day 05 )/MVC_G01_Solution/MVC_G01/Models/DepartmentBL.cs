using Microsoft.EntityFrameworkCore;
using MVC_G01.Data.DbContexts;

namespace MVC_G01.Models
{
    // Container Operations on Department
    public class DepartmentBL
    {
        CorporateDbContext context = new CorporateDbContext();
        // 1- Getall Departments

        // Explicit loading > include
        public List<Department> GetAll()
        {
           return context.Departments.Include(D=>D.Employees).ToList();
        }

        // 2- Add Department
        public void AddDept(Department Dept)
        {
            // Add to lacal
            context.Add(Dept);
            // Add to Database
            context.SaveChanges();
        }
    }
}
