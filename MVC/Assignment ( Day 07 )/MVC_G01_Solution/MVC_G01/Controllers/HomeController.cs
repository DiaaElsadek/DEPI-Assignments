using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_G01.Models;

namespace MVC_G01.Controllers
{
    // /Controller/method
    // /Home/Privacy
    // /Home/Index

    // 1- Controller to be mapped :
    // >> end with "Controller" >> Naming Convention : Lifecycle
    // >> httpContx : httpreq , httpresponse
    // >> inherit from Controller

    // obj created from this class for every request
    // Controller factory >> self
    // builder.Services.AddControllersWithViews(); >> self
    // Dependency injection >> self

    public class HomeController : Controller
    {
        // Method : 
        // 1- be public
        // 2- not be static
        // 3- can't be overloaded

        
        // Expected : return Views
        // Method >> Action or EndPoint

        // Action : special return types
        // string   >>   ContentResult
        // view     >>   ViewResult
        // Json     >>   JsonResult
        // file     >>   FileResult
        // notfound>>    NotFounResult
        //un authorized 
        // ......

        // Unified signatures : Generalization 
        // ActionResult : IActionResult

        // /Home/ShowMsg
        public ContentResult ShowMsg()
        {
           // Complex Data type
           // declare 
           ContentResult result = new ContentResult();
            // Initial
            result.Content = "Hello Rowad !";
            // return
            return result;
        }

        // /Home/ShowView
        public ViewResult ShowView()
        {
            //declare
            ViewResult result = new ViewResult();
            //initial
            result.ViewName = "View1";
            // return
            return result ;
        }


        // Generalization : OOP
        // Iactionresult is the return type of all endpoints
        // Helper Method

        // /Home/ShowMix?id=4
        // Query string
        public IActionResult ShowMix(int id)
        {
            if(id % 2 == 0)
            {
                return View("View1");
            }
            else
            {
                return Content("Hello Rowad !");
            }   
        }


        // Functionality : repeated >> function : Reusable
        public ViewResult view(string ViewName)
        {
            //declare
            ViewResult result = new ViewResult();
            //initial
            result.ViewName = "ViewName";
            // return
            return result;
        }
        
        public void test()
        {
            dynamic X = 3;
            dynamic a;
            dynamic Y = new Employee();
            dynamic Z = X+Y;
        }

        // MS?
        // Helper Method


        // Views : Pages
        // 1- View All Departments 

        // Model ? Data / BL 
        // Data :
        // 1- Class Diagram >> System Design >> self
        // 2- Build Classes of our system
        // 3- Environment > Pkges of EF
        // 4- Call DB
        // BL (Operations) > Retreival
        // Data Seed >> self
        
        // Controller 

        // View

        // 2- View Specific Employee
        // Model
        // Controller
        // View
        







        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
