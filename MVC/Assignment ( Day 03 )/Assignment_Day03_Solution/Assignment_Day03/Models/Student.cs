using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_Day03.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public int Age { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        // Navigation property
        public Department Department { get; set; }

        // Many-to-many relationship with Courses via StuCrsRes
        public ICollection<StuCrsRes> StuCrsRes { get; set; }
    }
}
