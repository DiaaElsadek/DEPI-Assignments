using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Student S1 = new Student(1, "Ahmed", new Grade(90));

            Student ShallowCopy = S1;

            Student DeepCopy = new Student(S1);

            // Before Changes (Orginal)
            Console.WriteLine(S1);

            // Shallow Copy
            Console.WriteLine(ShallowCopy);

            // Deep Copy
            Console.WriteLine(DeepCopy);

            S1.Grade.Score = 60;

            // Before Changes (Orginal)
            Console.WriteLine(S1); // 60

            // Shallow Copy
            Console.WriteLine(ShallowCopy); // 60

            // Deep Copy
            Console.WriteLine(DeepCopy); // 90

            #region Question

            // Question: What is the primary purpose of a copy constructor in C#? 

            // Question: What is the primary purpose of a copy constructor in C#?
            // Answer: The primary purpose of a copy constructor is to create a new object 
            // as a copy of an existing object, initializing the new object's fields or properties 
            // with the same values as the original.

            #endregion

        }
    }
}
