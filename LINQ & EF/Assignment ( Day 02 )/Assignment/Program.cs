using System;
using System.Linq;

namespace TaskDay02EF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators

            Console.WriteLine("=== LINQ - Restriction Operators ===");

            // 1. Get all products that are out of stock
            Console.WriteLine("1. Products out of stock:");
            var outOfStockProducts = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0);
            foreach (var product in outOfStockProducts)
                Console.WriteLine($"   {product.ProductName}");

            // 2. Get all products that are in stock and cost more than 3.00 per unit
            Console.WriteLine("\n2. Products in stock and cost > 3.00:");
            var expensiveInStockProducts = ListGenerators.ProductList
                .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
            foreach (var product in expensiveInStockProducts)
                Console.WriteLine($"   {product.ProductName} - Price: {product.UnitPrice:C}");

            // 3. Get digits whose name length is shorter than their value
            Console.WriteLine("\n3. Digits whose name is shorter than their value:");
            string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortNamedDigits = digitNames.Where((name, index) => name.Length < index);
            foreach (var digit in shortNamedDigits)
                Console.WriteLine($"   {digit}");

            #endregion

            #region LINQ - Element Operators

            Console.WriteLine("\n=== LINQ - Element Operators ===");

            // 1. Get the first product that is out of stock
            Console.WriteLine("1. First product out of stock:");
            var firstOutOfStock = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            Console.WriteLine($"   {firstOutOfStock?.ProductName ?? "None"}");

            // 2. Get the first product with price > 1000, or "None" if not found
            Console.WriteLine("\n2. First product with price > 1000:");
            var expensiveProduct = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine($"   {expensiveProduct?.ProductName ?? "None"}");

            // 3. Get the second number greater than 5
            Console.WriteLine("\n3. Second number greater than 5:");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var secondGreaterThan5 = numbers.Where(n => n > 5).Skip(1).FirstOrDefault();
            Console.WriteLine($"   {secondGreaterThan5}");

            #endregion

            #region LINQ - Aggregate Operators

            Console.WriteLine("\n=== LINQ - Aggregate Operators ===");

            // 1. Count how many odd numbers are in the array
            Console.WriteLine("1. Count of odd numbers:");
            int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var oddCount = arr.Count(n => n % 2 == 1);
            Console.WriteLine($"   {oddCount}");

            // 2. List customers and how many orders each one has
            Console.WriteLine("\n2. Customers and their order count:");
            var customerOrderCounts = ListGenerators.CustomerList
                .Select(c => new { CustomerName = c.Name, OrderCount = c.Orders?.Length ?? 0 });
            foreach (var customer in customerOrderCounts)
                Console.WriteLine($"   {customer.CustomerName}: {customer.OrderCount} orders");

            // 3. List categories and how many products each one has
            Console.WriteLine("\n3. Categories and product count:");
            var categoryProductCounts = ListGenerators.ProductList
                .GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, ProductCount = g.Count() });
            foreach (var category in categoryProductCounts)
                Console.WriteLine($"   {category.Category}: {category.ProductCount} products");

            // 4. Calculate the total of numbers in the array
            Console.WriteLine("\n4. Total of numbers in array:");
            var totalSum = arr.Sum();
            Console.WriteLine($"   {totalSum}");

            // 5. Total characters in dictionary (simulated with sample words)
            Console.WriteLine("\n5. Total characters in dictionary:");
            string[] sampleWords = { "apple", "banana", "cherry", "date", "elderberry" };
            var totalChars = sampleWords.Sum(w => w.Length);
            Console.WriteLine($"   Sample words total characters: {totalChars}");

            // 6. Total units in stock for each product category
            Console.WriteLine("\n6. Total units in stock by category:");
            var categoryStockTotals = ListGenerators.ProductList
                .GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });
            foreach (var category in categoryStockTotals)
                Console.WriteLine($"   {category.Category}: {category.TotalUnits} units");

            // 7. Find the length of the shortest word
            Console.WriteLine("\n7. Length of shortest word:");
            var shortestWordLength = sampleWords.Min(w => w.Length);
            Console.WriteLine($"   {shortestWordLength}");

            // 8. Get the cheapest price in each category
            Console.WriteLine("\n8. Cheapest price in each category:");
            var cheapestPrices = ListGenerators.ProductList
                .GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });
            foreach (var category in cheapestPrices)
                Console.WriteLine($"   {category.Category}: {category.CheapestPrice:C}");

            // 9. Get products with the cheapest price in each category (using let)
            Console.WriteLine("\n9. Cheapest products in each category:");
            var cheapestProducts = from p in ListGenerators.ProductList
                                   group p by p.Category into g
                                   let minPrice = g.Min(product => product.UnitPrice)
                                   select new { Category = g.Key, Products = g.Where(product => product.UnitPrice == minPrice) };
            foreach (var category in cheapestProducts)
            {
                Console.WriteLine($"   {category.Category}:");
                foreach (var product in category.Products)
                    Console.WriteLine($"     {product.ProductName} - {product.UnitPrice:C}");
            }

            // 10. Find the length of the longest word
            Console.WriteLine("\n10. Length of longest word:");
            var longestWordLength = sampleWords.Max(w => w.Length);
            Console.WriteLine($"   {longestWordLength}");

            // 11. Get the most expensive price in each category
            Console.WriteLine("\n11. Most expensive price in each category:");
            var expensivePrices = ListGenerators.ProductList
                .GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, ExpensivePrice = g.Max(p => p.UnitPrice) });
            foreach (var category in expensivePrices)
                Console.WriteLine($"   {category.Category}: {category.ExpensivePrice:C}");

            // 12. Get products with the most expensive price in each category
            Console.WriteLine("\n12. Most expensive products in each category:");
            var expensiveProducts = ListGenerators.ProductList
                .GroupBy(p => p.Category)
                .Select(g => new {
                    Category = g.Key,
                    MaxPrice = g.Max(p => p.UnitPrice),
                    Products = g.Where(p => p.UnitPrice == g.Max(pr => pr.UnitPrice))
                });
            foreach (var category in expensiveProducts)
            {
                Console.WriteLine($"   {category.Category}:");
                foreach (var product in category.Products)
                    Console.WriteLine($"     {product.ProductName} - {product.UnitPrice:C}");
            }

            // 13. Calculate the average length of words
            Console.WriteLine("\n13. Average length of words:");
            var avgWordLength = sampleWords.Average(w => w.Length);
            Console.WriteLine($"   {avgWordLength:F2}");

            // 14. Calculate the average price of products in each category
            Console.WriteLine("\n14. Average price by category:");
            var avgPrices = ListGenerators.ProductList
                .GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) });
            foreach (var category in avgPrices)
                Console.WriteLine($"   {category.Category}: {category.AvgPrice:C}");

            #endregion

        }
    }
}
