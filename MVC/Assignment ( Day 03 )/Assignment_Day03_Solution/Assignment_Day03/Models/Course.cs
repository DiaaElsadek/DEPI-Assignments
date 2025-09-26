using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_Day03.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Degree { get; set; }

        public int MinDegree { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<StuCrsRes> StuCrsRes { get; set; }
    }
}
