using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Teacher
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Salary { get; set; }

    public string Address { get; set; }

    public int? CourseId { get; set; }
    public Course Course { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}
