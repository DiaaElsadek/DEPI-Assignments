using Assignment_Day03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_G01.Data.DbContexts;

public class DepartmentController : Controller
{
    private readonly CorporateDbContext _context;

    public DepartmentController(CorporateDbContext context)
    {
        _context = context;
    }

    // ShowAll
    public IActionResult Index()
    {
        var departments = _context.Departments.ToList();
        return View(departments); // LifeCycle: Controller -> View
    }

    // ShowDetails(int id)
    public IActionResult Details(int id)
    {
        var department = _context.Departments
            .Include(d => d.Students)
            .FirstOrDefault(d => d.Id == id);

        if (department == null) return NotFound();

        return View(department); // LifeCycle: Controller -> View
    }

    // Add
    [HttpGet]
    public IActionResult Create()
    {
        return View(); // LifeCycle: GET -> Form
    }

    [HttpPost]
    public IActionResult Create(Department department)
    {
        if (ModelState.IsValid)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(department); // LifeCycle: POST -> Validation -> Save DB
    }
}
