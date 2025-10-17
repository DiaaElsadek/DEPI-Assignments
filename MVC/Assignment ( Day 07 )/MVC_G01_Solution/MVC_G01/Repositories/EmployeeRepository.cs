using Microsoft.EntityFrameworkCore;
using MVC_G01.Data.DbContexts;
using MVC_G01.Models;

namespace MVC_G01.Repositories
{
    public class EmployeeRepository :IEmployeeRepository
    {
        CorporateDbContext _context;
        public EmployeeRepository()
        {
            _context = new CorporateDbContext();
        }

        // basic CRUD 
        public void Add(Employee employee)
        {
            // Add to cache
            _context.Add(employee);
            
        }
        public void Update(Employee employee)
        {
            // Update to cache
            _context.Update(employee); //Modeified
        }
        public void Delete(Employee employee)
        {
            _context.Remove(employee); 
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(E => E.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        // Extra
        public Employee GetByIdWithLoading(int id)
        {
            return _context.Employees.Include(e=>e.Department).FirstOrDefault(E => E.Id == id);
        }
    }
}
