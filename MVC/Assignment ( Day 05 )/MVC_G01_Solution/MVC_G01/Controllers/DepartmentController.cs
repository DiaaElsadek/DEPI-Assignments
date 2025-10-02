using Microsoft.AspNetCore.Mvc;
using MVC_G01.Models;

namespace MVC_G01.Controllers
{
    // Separation of Concern
    // Container of Actions relate to Department : OpeRATION process
    public class DepartmentController : Controller
    {
        // Req Handler : Routing Mapping >> Req URL
        // BL Coordinator >> Call Model (Data/BL)
        // Provide response >> Send data to view (select view)

        // EF by default not loaded related entitites(Navigation properties)
        // Explicit Loading >> USed Now
        // Lazy loading >> Load on demand (When using) >> self
        // Eager Loading >> Self

        DepartmentBL departmentBL = new DepartmentBL();
        // /Department/Index
        [HttpGet]
        public IActionResult Index()
        {
            // Index : Default action > default page >> Getall Records(Categories)
            List<Department> DeptsList=departmentBL.GetAll();
            return View("Index", DeptsList);
        }

        // /Department/Add?Name=Java&Mgrname=Ali
        // Add(string name,string Mgrname)
        // Map req data / parameters of action
        // Model Binding

        // 1- Add : Open Form >> Add Page
        // /Department/Add
        // Read Action 

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");  // Model : null
        }

        // 2- Action : Save Entity to Database
        // /Department/SaveAdd?Name=SD&MgrName=ALi
        // FormData >> form

        // action in Mvc :
        // req : get or post ?!

        // if(req.Method ==" Post")

        // filter : self 
        // status code : 405 : self 

        [HttpPost]
        // Action 
        // transaction on db >> httppost 
        public IActionResult SaveAdd(Department DeptSent)
        {
            // testing : 
            // Test cases
            if(DeptSent.Name != null)
            {
                // Save to DB
                departmentBL.AddDept(DeptSent);
                // if saved
                // DRY : Don't repeat ur self
                //return View("Index", departmentBL.GetAll());
                return RedirectToAction(nameof(Index));
            }

            return View("Add", DeptSent); // model Department
        }
    }
}
