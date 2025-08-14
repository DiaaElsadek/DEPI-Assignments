using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    internal class Employee
    {

        private int Id;
        private string Name;
        private double Salary;

        public Employee(double _Salary, string _Name)
        {
            Name = _Name;
            Salary = _Salary;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string newName)
        {
            Name = newName;
        }

        public double EmployeeSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        public int GetId()
        {
            return Id;
        }

    }
}
