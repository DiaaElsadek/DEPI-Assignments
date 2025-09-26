using Microsoft.AspNetCore.Mvc.Rendering;

public class DepartmentViewModel
{
    public string DepartmentName { get; set; }
    public List<SelectListItem> StudentsAbove25 { get; set; }
    public string DepartmentState { get; set; }
}
