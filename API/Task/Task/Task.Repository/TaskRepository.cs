using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Core.Repository_Contract;
using Task.Repository.Data;

namespace Task.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskDbContext _context;

        public TaskRepository(TaskDbContext context)
        {
            _context = context;
        }
        public async Task<Core.Entity.Task> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }
        public async Task<IReadOnlyList<Core.Entity.Task>> GetAllTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }
        public bool AddTask(Core.Entity.Task Task)
        {
            if(Task == null) return false;
            _context.Tasks.AddAsync(Task);
            _context.SaveChanges();
            return true;
        }
        public bool DeleteTask(int id)
        {
            if(id <= 0) return false;
            var task =  _context.Tasks.Find(id);
            _context.Tasks.Remove(task); 
            _context.SaveChanges();
            return true;
        }
        public bool UpdateTask(Core.Entity.Task Task)
        {
            if(Task == null) return false;
            _context.Update(Task);
            _context.SaveChanges();
            return true;
        }

        public async Task<IEnumerable<Core.Entity.Task>> GetByCompletionStatusAsync(bool isCompleted)
        {
            return await _context.Tasks.Where(t => t.IsCompleted == isCompleted).ToListAsync();
        }

        public async Task<IEnumerable<Core.Entity.Task>> GetAllSortedByDueDateAsync(bool ascending = true)
        {
            return await _context.Tasks
                .OrderBy(t => ascending ? t.DueDate : DateTime.MaxValue - (t.DueDate - DateTime.MinValue))
                .ToListAsync(); 
        }
    }
}
