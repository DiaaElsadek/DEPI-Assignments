using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Core.Service_Contract;
namespace Task.Controllers
{
    public class TaskController : BaseApiController
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Task.Core.Entity.Task>>> GetAll()
        {
            var tasks = await _taskService.GetAllTasksAsync();
            return Ok(tasks);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Task.Core.Entity.Task>> GetById(int id)
        {
            var task = await _taskService.GetTaskByIdAsync(id);
            if (task == null)
            {
                return NotFound("Task Not Found");
            }
            return Ok(task);
        }
        [HttpPut]
        public async Task<ActionResult<bool>> Update(Task.Core.Entity.Task task)
        {
            var existingTask = await _taskService.GetTaskByIdAsync(task.Id);
            if (existingTask is null)
            {
                return NotFound("Task Not Found");
            }
            _taskService.UpdateTask(task);
            return Ok("Task Updated Successfully");
        }
        [HttpPost]
        public async Task<ActionResult<bool>> CreateTask(Task.Core.Entity.Task task)
        {
            _taskService.AddTask(task);
            return Ok("Task Created Successfully");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var existingTask = await _taskService.GetTaskByIdAsync(id);
            if (existingTask is null)
            {
                return NotFound("Task Not Found");
            }
            _taskService.DeleteTask(id);
            return Ok("Task Deleted Successfully");
        }
        [HttpGet("filter-isCompleted")]
        public async Task<ActionResult<IEnumerable<Task.Core.Entity.Task>>> GetByCompletionStatus([FromQuery] bool isCompleted)
        {
            var tasks = await _taskService.GetByCompletionStatusAsync(isCompleted);
            return Ok(tasks);
        }
        [HttpGet("sort-by-dueDate")]
        public async Task<ActionResult<IEnumerable<Task.Core.Entity.Task>>> GetAllSortedByDueDate([FromQuery] bool ascending = true)
        {
            var tasks = await _taskService.GetAllSortedByDueDateAsync(ascending);
            return Ok(tasks);
        }
    }
}
