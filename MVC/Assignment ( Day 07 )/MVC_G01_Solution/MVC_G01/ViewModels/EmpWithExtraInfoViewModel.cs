namespace MVC_G01.ViewModels
{
    public class EmpWithExtraInfoViewModel
    {
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public string Status { get; set; }
        public int Rate { get; set; }
        public List<string> Skills { get; set; }
    }
}
