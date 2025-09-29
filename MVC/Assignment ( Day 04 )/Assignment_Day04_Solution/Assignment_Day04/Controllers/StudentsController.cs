using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class StudentsController : Controller
{
    private readonly AppDbContext _context;
    private const int PageSize = 5; // عدد العناصر في الصفحة الواحدة

    public StudentsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Students
    public async Task<IActionResult> Index(string searchString, int? departmentId, int page = 1)
    {
        var query = _context.Students.Include(s => s.Department).AsQueryable();

        // البحث بالاسم
        if (!string.IsNullOrEmpty(searchString))
        {
            query = query.Where(s => s.Name.Contains(searchString));
        }

        // الفلترة بالقسم
        if (departmentId.HasValue && departmentId.Value > 0)
        {
            query = query.Where(s => s.DepartmentId == departmentId.Value);
        }

        // إجمالي عدد الطلاب بعد الفلترة
        var totalStudents = await query.CountAsync();

        // Pagination
        var students = await query
            .OrderBy(s => s.Id)
            .Skip((page - 1) * PageSize)
            .Take(PageSize)
            .ToListAsync();

        // تجهيز الـ ViewBag للـ Dropdown الخاص بالأقسام
        ViewBag.Departments = new SelectList(_context.Departments, "Id", "Name");
        ViewBag.CurrentSearch = searchString;
        ViewBag.CurrentDepartment = departmentId;
        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = (int)Math.Ceiling(totalStudents / (double)PageSize);

        return View(students);
    }

    // GET: Students/Details/5
    public async Task<IActionResult> Details(int id)
    {
        var student = await _context.Students
            .Include(s => s.Department)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (student == null) return NotFound();

        return View(student);
    }

    // GET: Students/Create
    public IActionResult Create()
    {
        ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
        return View();
    }

    // POST: Students/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Student student)
    {
        if (ModelState.IsValid)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", student.DepartmentId);
        return View(student);
    }

    // GET: Students/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null) return NotFound();

        ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", student.DepartmentId);
        return View(student);
    }

    // POST: Students/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Student student)
    {
        if (id != student.Id) return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Students.Any(e => e.Id == student.Id))
                    return NotFound();
                else
                    throw;
            }
        }
        ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", student.DepartmentId);
        return View(student);
    }

    // GET: Students/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        var student = await _context.Students
            .Include(s => s.Department)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (student == null) return NotFound();

        // عرض صفحة تحذير قبل الحذف
        return View("DeleteWarning", student);
    }

    // POST: Students/DeleteConfirmed/5
    [HttpPost, ActionName("DeleteConfirmed")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }
}
