using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MVC_G01.Models
{
    // design model(Domain/view Model)
    // 1- property displayed ? - Data type appeneded to input?
    // 2- Validation criteria (Model Validation)
    // 3- error msg for all validation
    public class Employee
    {
        // .Net 6.0 - Common Practice
        public int Id { get; set; }
        [Display(Name="Full Name")]
        //[DataType(DataType.Password)]
        [Required(ErrorMessage ="Required Field")]
        [MaxLength(30,ErrorMessage ="Less than 30")]
        [MinLength(3,ErrorMessage ="More than 3")]
        [RegularExpression(@"^[a-zA-Z\s]+$",ErrorMessage ="contains only letters and spaces")]
        public string Name { get; set; } // Required
        public string Title { get; set; }
        [MinLength(3,ErrorMessage ="More than 3")]
        [MaxLength(30,ErrorMessage ="Less than 30")]
        [RegularExpression(@"^[a-zA-Z0-9!@#&\s-_]$",ErrorMessage ="contains only letters, spaces, digits and !@#_-&")]
        public string? Address { get; set; }
        [Required(ErrorMessage ="Required")]
        [Range(7000, 20000,ErrorMessage ="between 7000 and 20000")]
        public int Salary { get; set; }  // Required

        // FK : 
        // 1- DepartmentId
        // 2-1 DepartmentId > same Naming
        // 2-2 DepartmentId > same Naming,[FK()] >> recommended
        [ForeignKey("Department")]
        [Display(Name="Department")]
        [Required(ErrorMessage ="Required")]
        [Range(1,int.MaxValue,ErrorMessage ="Enter valid department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
