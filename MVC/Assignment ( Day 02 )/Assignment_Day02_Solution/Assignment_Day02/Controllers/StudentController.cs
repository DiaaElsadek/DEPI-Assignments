using Assignment_Day02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

public class StudentController : System.Web.Mvc.Controller
{

    private static List<Student> students = new List<Student>
    {
        new Student { Id = 1, Name = "Ahmed", Age = 20 },
        new Student { Id = 2, Name = "Sara", Age = 22 },
        new Student { Id = 3, Name = "Omar", Age = 19 }
    };

    // /Student/ShowAll
    public System.Web.Mvc.ActionResult ShowAll()
    {
        return View(students);
    }

    // /Student/ShowDetails?id=3
    public System.Web.Mvc.ActionResult ShowDetails(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
            return HttpNotFound();
        }
        return View(student);
    }
}
