using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_Day03.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public decimal Salary { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        // Navigation properties
        public Course Course { get; set; }
        public Department Department { get; set; }
    }
}
