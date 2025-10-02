using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_G01.Models;
using MVC_G01.ViewModels;

namespace MVC_G01.Controllers
{
    public class EmployeeController : Controller
    {
        // Req Handler
        // BL coordinator (BL Process) >> call Model (BL/Data)
        // Slect View(UI) >> Send Data to it

        //send on info to view 
        //More than one info 
        // Bag >> Controller to view 
        // more than one info 
        // Collections 
        // 1- ViewData >> what collection? >> prior definitions 
        // Dictionary : Key value pairs
        // <string,object> >> hold anything
        // dict["Ali"] = 67;

        // 2- ViewBag >> ViewData > dynamic
        //  ViewData["Rate"] = Rate;
        //  ViewBag.Rate = Rate;

        // Pass small pieces of data has no relation model :Page title

        // what the solution ?
        // Custom class (Encapsulate for info sent to view)
        // Action based on this Model
        // ViewModel

        // 1- Customization >> needed properties only 
        // Light object >> Performance on server level
        // Merge more than one model >> business / validations
        // Security : different definition >> Apis (DTOs)
        // Separate of concern : validations

        // VM :
        // name - dept - rate -skills -status


        EmployeeBL employeeBL = new EmployeeBL();
        DepartmentBL departmentBL = new DepartmentBL(); 

        // /Employee/Details?id=2
        // based on model
        public IActionResult Details(int id)
        {
            
            // additional other info to view
            int Rate = 67;
            string Status = "B";
            List<string> Skills = new List<string>() { "Communication" , "TeamWork"};

            //Set 
            ViewData["Rate"] = Rate;
            ViewData["Status"] = Status;
            ViewData["Skills"] = Skills;

            Employee employee=employeeBL.GetById(id);
            return View("Details", employee);  // Model : Employee
        }

        // based on ViewModel
        public IActionResult DetailsVM(int id) 
        { 
            // Custom class > ViewModel
            // Sources(Model/Static) >> Destination(ViewModels)
            // 1-Source 
            Employee EmpModel = employeeBL.GetById(id);
            int Rate = 67;
            string Status = "B";
            List<string> Skills = new List<string>() { "Communication", "TeamWork" };
            // 2-Destination : Map from model to viewmodel
            EmpWithExtraInfoViewModel EVM = new EmpWithExtraInfoViewModel()
            {
                EmpName= EmpModel.Name,
                DeptName = EmpModel.Department.Name,
                Rate = Rate,
                Status = Status,
                Skills = Skills
            };
            // 3- send ViewModel
            return View("DetailsVM", EVM);

        }

        public IActionResult Index()
        {
            return View("Index",employeeBL.GetAll());
        }

        // Edit life cycle :
        // 1- UX : Index
        // 2- Action : open edit form
        //    old object vistualized
        // 3- view of Edit
        // 4- secon action : SaveEdit

        // Dilemma :
        // merge 2 models : Employee + List<Department>
        // ViewModel : Shape Data
        // Sources - Destination - Mapping
        
        // Lifecycle :
        // 1- first action open page alert
        // 2- Page/View od Delete
        // 3- second action : ConfirmDelete

        // first action 
        public IActionResult Edit(int id)
        {
            // Automapper >> self
            // Sources
            //Employee
            Employee Emp = employeeBL.GetById(id);
            //List<Dept>
            List<Department> DeptList = departmentBL.GetAll();

            // Destination >> Map
            EmpDeptViewModel EDVM = new EmpDeptViewModel()
            {
                Id = Emp.Id,
                Name = Emp.Name,
                Salary = Emp.Salary,
                Address = Emp.Address,
                Title = Emp.Title,
                DepartmentId = Emp.DepartmentId,
                DeptList = DeptList
            };

            // open edit form
            return View("Edit", EDVM); // Model : EmpDeptViewModel
        }

        // SaveEdit
        [HttpPost]
        public IActionResult SaveEdit(Employee NewEmp,int id)
        {
            // Updating
            // oldEmp
            Employee OldEmp = employeeBL.GetById(id);
            if(NewEmp.Name != null)
            {
                // oldemp = newemp >> local
                OldEmp.Id = NewEmp.Id;
                OldEmp.Name = NewEmp.Name;
                OldEmp.Salary = NewEmp.Salary;
                OldEmp.Title = NewEmp.Title;
                OldEmp.Address = NewEmp.Address;
                OldEmp.DepartmentId = NewEmp.DepartmentId;
                // saving >> DB
                employeeBL.SaveInDB();
                // if saved
                return RedirectToAction(nameof(Index));
            }
            return View("Edit", NewEmp);
        }

        // Delete action
        // /Employee/Delete/1
        public IActionResult Delete(int id)
        {
            return View("Delete",employeeBL.GetById(id));
        }

        // Remove from DB
        public IActionResult ConfirmDelete(int id)
        {
            // catch
            Employee Emp = employeeBL.GetById(id);
            if(Emp != null)
            {
                // remove
                employeeBL.DeleteInDB(Emp);
                // if removed
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }

        // Life cycle of Add :
        // 1- UX : Index >> New
        // 2- Add : open add form/page
        // 3- SaveAdd : Save to DB (Write)
        // 4- View 

        // UX : Dilemma :
        // List<Department> : VB/VD

        public IActionResult Add()
        {
            ViewData["DeptList"]=new SelectList(departmentBL.GetAll(),"Id","Name");
            return View("Add"); //Model: Null
        }

        public IActionResult SaveAdd(Employee NewEmp)
        {
            // DB + Business needs
            // inlin validation
            //if(NewEmp.Name != null && NewEmp.Salary > 7000 && NewEmp.Id !=0)
            if(ModelState.IsValid)
            {
                // save/Add
                // BL container
                employeeBL.Add(NewEmp);
                // if saved 
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeptList"] = new SelectList(departmentBL.GetAll(),"Id","Name");
            return View("Add", NewEmp); // Model: Employee
        }
    }
}
