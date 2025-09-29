using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Student
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public int Age { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public ICollection<StuCrsRes> StuCrsRes { get; set; }
}
