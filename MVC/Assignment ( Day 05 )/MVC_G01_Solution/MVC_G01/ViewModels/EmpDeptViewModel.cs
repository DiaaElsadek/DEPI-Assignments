using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC_G01.Models;

namespace MVC_G01.ViewModels
{
    // Custom class > ViewMode
    public class EmpDeptViewModel
    {
        // Model01 : Employee
        public int Id { get; set; }

        [Display(Name ="Full Name")]
        //[DataType(DataType.Password)]
        public string Name { get; set; } 
        public string Title { get; set; }
        public string? Address { get; set; }
        public int Salary { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        // Model 02 : List<Department>
        public List<Department> DeptList { get; set; }
    }
}
