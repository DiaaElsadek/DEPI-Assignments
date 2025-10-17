using Core.Interfaces;
using Core.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        TestCaseDbContext _context;
        public TaskRepository()
        {
            _context = new TestCaseDbContext();
        }

        // basic CRUD 
        public void Add(TaskItem taskitem)
        {
            // Add to cache
            _context.Add(taskitem);
        }
        public void Update(TaskItem taskitem)
        {
            // Update to cache
            _context.Update(taskitem); //Modeified

        }
        public void Delete(TaskItem taskitem)
        {
            _context.Remove(taskitem);
        }

        public List<TaskItem> GetAll()
        {
            return _context.Tasks.ToList();
        }
        public TaskItem GetById(int id)
        {
            return _context.Tasks.FirstOrDefault(d => d.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
