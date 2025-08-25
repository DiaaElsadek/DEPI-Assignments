using Problem_2.Interfaces;
using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IShape shape = new Circle();

            shape.PrintDetailds();

            #region Question

            // Question: What are the benefits of default implementations in interfaces introduced in C# 8.0?

            // The benefits of default implementations in interfaces (C# 8.0) are:
            // 1. They allow adding new members to interfaces without breaking existing implementations.
            // 2. They enable code reusability by providing common method logic in the interface itself.
            // 3. They reduce the need for abstract classes when only shared behavior is required.
            // 4. They improve API evolution by letting developers extend interfaces safely over time.

            #endregion

        }
    }
}
