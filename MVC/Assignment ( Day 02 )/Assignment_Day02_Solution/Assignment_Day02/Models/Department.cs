namespace Assignment_Day02.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MgrName { get; set; }

        // Navigation
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
