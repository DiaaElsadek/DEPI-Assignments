using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Core.Entity;

namespace Task.Core.Repository_Contract
{
    public interface ITaskRepository
    {
        Task<IReadOnlyList<Entity.Task>> GetAllTasksAsync();
        Task<Entity.Task> GetTaskByIdAsync(int id);
        bool AddTask(Entity.Task Task);
        bool UpdateTask(Entity.Task Task);
        bool DeleteTask(int id);
        Task<IEnumerable<Entity.Task>> GetByCompletionStatusAsync(bool isCompleted);
        Task<IEnumerable<Entity.Task>> GetAllSortedByDueDateAsync(bool ascending = true);
    }
}
