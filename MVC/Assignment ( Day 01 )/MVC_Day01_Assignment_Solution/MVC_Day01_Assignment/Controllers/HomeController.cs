using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Day01_Assignment.Models;

namespace MVC_Day01_Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult ShowMsg()
        {
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
            return result;
        }

        public IActionResult ShowMix(int id)
        {
            if (id % 2 == 0)
            {
                return View("View1");
            }
            else
            {
                return Content("Hello World !");
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
