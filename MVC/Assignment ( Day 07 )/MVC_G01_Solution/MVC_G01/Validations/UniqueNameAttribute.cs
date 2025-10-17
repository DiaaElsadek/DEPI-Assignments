using System.ComponentModel.DataAnnotations;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MVC_G01.Data.DbContexts;
using MVC_G01.Models;

namespace MVC_G01.Validations
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // check valid value
            if(value == null)
                return null;  // Skip validation
            // catch value/input
            string NewName = value.ToString();
            // search in DB based on Name
            CorporateDbContext context = new CorporateDbContext();
            Employee Emp=context.Employees.FirstOrDefault(e => e.Name == NewName);
            // null(good) , name(bad)
            if(Emp != null)
            {
                //return new ValidationResult("Name is Repeated!");
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
