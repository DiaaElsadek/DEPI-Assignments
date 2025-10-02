using Microsoft.AspNetCore.Mvc;
using MVC_G01.Models;
using static System.Net.Mime.MediaTypeNames;

namespace MVC_G01.Controllers
{
    public class BindController : Controller
    {
        // Binding :
        // Form data
        // Route values
        // Query string
        // Default value

        // id : Special
        // Routing : 3 place holders : 3rd nullable id

        // Req :
        // /Bind/Test?nAme=ALi&Age=34
        // /Bind/Test?nAme=ALi&Age=34&color=red
        // /Bind/Test?nAme=ALi
        
        // /Bind/Test?name=ALi&Age=34&id=2
        // /Bind/Test/2?name=ALi&Age=34
        // /Bind/Test/2?name=ALi&Age=34&id=4
        public IActionResult Test(string Name,int Age,int id)
        {
            return Content("Yep");
        }

        // Add/Post transaction ?
        // Add Primitive >> Model/ViewModel
        // /Bind/Testobj?Id=2&Name=SD&MgrName=Ali
        public IActionResult Testobj(Department dept)
        {
            return Content("Yep");
        }
    }
}
