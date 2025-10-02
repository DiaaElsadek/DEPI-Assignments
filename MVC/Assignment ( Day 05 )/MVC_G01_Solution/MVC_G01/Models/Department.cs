namespace MVC_G01.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? MgrName { get; set; }
        
        public List<Employee>? Employees { get; set; }
    }
}
