using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Core.Entity;
using Task.Core.Repository_Contract;
using Task.Core.Service_Contract;

namespace Task.Service
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public bool AddTask(Core.Entity.Task Task)
        {
            if (Task.DueDate <= DateTime.Now)
                throw new ArgumentException("Due date must be in the future.");
            return _taskRepository.AddTask(Task);
        }

        public bool DeleteTask(int id)
        {
            return _taskRepository.DeleteTask(id);
        }

        public async Task<IEnumerable<Core.Entity.Task>> GetAllSortedByDueDateAsync(bool ascending = true)
        {
            return await _taskRepository.GetAllSortedByDueDateAsync(ascending);
        }

        public async Task<IReadOnlyList<Core.Entity.Task>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllTasksAsync();
        }

        public async Task<IEnumerable<Core.Entity.Task>> GetByCompletionStatusAsync(bool isCompleted)
        {
            return await _taskRepository.GetByCompletionStatusAsync(isCompleted);
        }

        public async Task<Core.Entity.Task> GetTaskByIdAsync(int id)
        {
            return await _taskRepository.GetTaskByIdAsync(id);
        }

        public bool UpdateTask(Core.Entity.Task Task)
        {
            if (Task.DueDate <= DateTime.Now)
                throw new ArgumentException("Due date must be in the future.");

            return  _taskRepository.UpdateTask(Task);
        }
    }
}
