﻿namespace Assignment_Day02.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<StuCrsRes> StuCrsRes { get; set; }
    }
}
