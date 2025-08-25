using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{

    class Grade
    {
        public int Score;

        public Grade(int score)
        {
            Score = score;
        }
    }
    class Student
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public Grade Grade { get; set; } // Reference Type Attribute

        // Constructor
        public Student(int _Id, string _Name, Grade _Grade)
        {
            Id = _Id;
            Name = _Name;
            Grade = _Grade;
        }

        // Copy Constructor [Deep Copy]
        public Student(Student other)
        {
            Id = other.Id;
            Name = other.Name;
            Grade = new Grade(other.Grade.Score); // Deep Copy For Grade as Object
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Grade: {Grade.Score}";
        }

    }
}
