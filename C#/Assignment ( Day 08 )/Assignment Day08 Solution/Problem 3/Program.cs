using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Products Array
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", 999.99),
                new Product(2, "Smartphone", 699.99),
                new Product(3, "Tablet", 399.99),
                new Product(4, "Monitor", 199.99),
                new Product(5, "Keyboard", 49.99),
            };

            Console.Clear();

            foreach(Product p in products)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            Array.Sort(products);

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

            #region Question

            // Question: How does implementing IComparable improve flexibility in sorting?  

            // Implementing IComparable improves flexibility in sorting because:
            // 1. It allows objects of a custom class to define their own natural ordering.
            // 2. Sorting algorithms (like Array.Sort or List.Sort) can work directly on your objects.
            // 3. You don’t need to write custom sorting logic every time – the CompareTo method handles it.
            // 4. It makes your class compatible with .NET collection methods that rely on comparisons.
            // 5. It provides consistency, reusability, and better maintainability for sorting operations.

            #endregion

        }
    }
}
