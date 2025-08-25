using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1, "Ahmed", 5000);

            Console.WriteLine(acc1);

            acc1.Balance = 3000; // Rejected

            Console.WriteLine(acc1); // 4000

            Account acc2 = new Account();
            acc2.AccountId = 2;
            acc2.AccountHolder = "Mona";
            acc2.Balance = 7000;

            Console.WriteLine(acc2);

            #region Question

            // Question: What is the key difference between encapsulation in structs and classes? 

            // Question: What is the key difference between encapsulation in structs and classes?
            // Answer: The key difference is that structs are value types and are stored on the stack, 
            // while classes are reference types and stored on the heap. This affects how encapsulated 
            // data is copied, passed, and managed in memory.

            #endregion

        }
    }
}
