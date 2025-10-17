using Microsoft.EntityFrameworkCore;
using MVC_G01.Models;

namespace MVC_G01.Repositories
{
    public interface IDepartmentRepository
    {
        public void Add(Department department);
        public void Update(Department department);
        public void Delete(Department department);

        public List<Department> GetAll();
        public Department GetById(int id);

        public void Save();
        public List<Department> GetAllWithLoading();  
    }
}
