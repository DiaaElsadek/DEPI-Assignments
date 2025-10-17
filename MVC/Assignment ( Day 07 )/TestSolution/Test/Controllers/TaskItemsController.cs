using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;




namespace Test.Controllers
{
    public class TaskItemsController : Controller
    {
        ITaskRepository _taskRepository;
        public TaskItemsController(ITaskRepository _taskRepository)
        {
            _taskRepository = _taskRepository;
        }

        // GET: Taskitems
        public IActionResult Index()
        {
            return View(_taskRepository.GetAll());
        }

        // GET: Taskitems/Details/5
        public IActionResult Details(int id)
        {
            var taskitem = _taskRepository.GetById(id);
            if (taskitem == null)
            {
                return NotFound();
            }

            return View(taskitem);
        }

        // GET: Taskitems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Taskitems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Description,IsCompleted,CreatedAt")] TaskItem taskitem)
        {
            if (ModelState.IsValid)
            {
                _taskRepository.Add(taskitem);
                _taskRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(taskitem);
        }

        // GET: Taskitems/Edit/5
        public IActionResult Edit(int id)
        {
            var taskitem = _taskRepository.GetById(id);
            if (taskitem == null)
            {
                return NotFound();
            }
            return View(taskitem);
        }

        // POST: Taskitems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Title,Description,IsCompleted,CreatedAt")] TaskItem taskitem)
        {
            if (id != taskitem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
                    _taskRepository.Update(taskitem);
                    _taskRepository.Save();
                
                return RedirectToAction(nameof(Index));
            }
            return View(taskitem);
        }

        // GET: Taskitems/Delete/5
        public IActionResult Delete(int id)
        {
            
            var taskitem = _taskRepository.GetById(id);
            if (taskitem == null)
            {
                return NotFound();
            }

            return View(taskitem);
        }

        // POST: Taskitems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var taskitem = _taskRepository.GetById(id);
            if (taskitem != null)
            {
                _taskRepository.Delete(taskitem);
                _taskRepository.Save();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
