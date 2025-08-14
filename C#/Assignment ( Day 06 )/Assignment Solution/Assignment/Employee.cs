using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Employee
    {

        // 1- Define a struct Employee with private attributes (EmpId, Name, Salary). 

        private int Id;
        private string Name;
        private double Salary;

        // 2- Use methods (GetName, SetName) and properties to access these attributes. 

        // Methods to access Name
        public string GetName()
        {
            return Name;
        }

        public void SetName(string newName)
        {
            Name = newName;
        }

        // Method to access Salary
        public double EmployeeSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        // Method to access Id
        public int GetId()
        {
            return Id;
        }

    }
}
