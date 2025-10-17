using Microsoft.EntityFrameworkCore;
using MVC_G01.Models;

namespace MVC_G01.Repositories
{
    public interface IEmployeeRepository
    {
        public void Add(Employee employee);
        public void Update(Employee employee);
        public void Delete(Employee employee);

        public List<Employee> GetAll();
        public Employee GetById(int id);

        public void Save();
        public Employee GetByIdWithLoading(int id);
    }
}
