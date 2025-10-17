using Microsoft.EntityFrameworkCore;
using MVC_G01.Data.DbContexts;
using MVC_G01.Models;

namespace MVC_G01.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        // open connection  to DB
        // Inline Initialization  VS   Ctor initialization
        // Readable
        // DI  >> self 
        // Testing Modularity  >> self
        // int as a return

        //CorporateDbContext _context=new CorporateDbContext();
        
        CorporateDbContext _context;
        public DepartmentRepository()
        {
            _context = new CorporateDbContext();
        }

        // basic CRUD 
        public void Add(Department department)
        {
            // Add to cache
            _context.Add(department);
        }
        public void Update(Department department)
        {
            // Update to cache
            _context.Update(department); //Modeified
           
        }
        public void Delete(Department department)
        {
            _context.Remove(department);
        }

        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }
        public Department GetById(int id)
        {
            return _context.Departments.FirstOrDefault(d => d.Id == id);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }

        // Actipepageresultsets 
        // TCL 
        // Unit Of Work  >> self

        // Extra

        public List<Department> GetAllWithLoading()
        {
            return _context.Departments.Include(D => D.Employees).ToList();
        }
    }
}
