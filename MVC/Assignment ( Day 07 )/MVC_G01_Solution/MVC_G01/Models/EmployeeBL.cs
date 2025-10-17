using Microsoft.EntityFrameworkCore;
using MVC_G01.Data.DbContexts;

namespace MVC_G01.Models
{
    // Container for all opoerations on Employee
    public class EmployeeBL
    {
        CorporateDbContext context = new CorporateDbContext();

        // 1- Get Employee By Id
        public Employee GetById(int id)
        {
            return context.Employees.Include(E=>E.Department).FirstOrDefault(e => e.Id == id);
        }
        // when find and when firstordefault ?
        public Employee GetByyId(int id)
        {
            return context.Employees.Find(id);
        }

        // 2- Get All
        // self : AsNotracking()
        public List<Employee> GetAll()
        {
            return context.Employees
                .ToList();
        }

        //// update
        //public void Update(Employee NewEmp)
        //{
        //    context.Update(NewEmp);
        //    context.SaveChanges();
        //}

        // SaveInDB
        public void SaveInDB()
        {
            context.SaveChanges();
        }

        // Delete : 
        public void DeleteInDB(Employee Empdeleted)
        {
            context.Remove(Empdeleted);
            context.SaveChanges();
        } 

        // Add
        public void Add(Employee Emp)
        {
            // Add to local
            context.Employees.Add(Emp);
            // Add to DB
            context.SaveChanges();
        }
    }
}
