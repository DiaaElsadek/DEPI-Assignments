using System;
using System.Collections.Generic;
using System.Linq;

// Employee Class
public class Employee : ICloneable
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public object Clone()
    {
        return new Employee { Name = this.Name, Salary = this.Salary };
    }
}

// Manager Class
public class Manager : Employee, IComparable<Manager>
{
    public int CompareTo(Manager other)
    {
        return this.Salary.CompareTo(other.Salary);
    }
}

// Generic SortingAlgorithm Class
public class SortingAlgorithm<T> where T : ICloneable
{
    public void Sort(T[] array, Comparison<T> comparer)
    {
        Array.Sort(array, comparer);
    }

    public static void Swap<TValue>(ref TValue a, ref TValue b)
    {
        TValue temp = a;
        a = b;
        b = temp;
    }
}

// SortingTwo Class
public class SortingTwo<T>
{
    public void Sort(T[] array, Comparison<T> comparer)
    {
        Array.Sort(array, comparer);
    }
}

public static class SortingAlgorithm
{
    public static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
}


public class Program
{
    static void Main()
    {
        // Problem 1: Sort Employee by Salary Ascending
        Employee[] employees = {
            new Employee{Name="Ali", Salary=5000},
            new Employee{Name="Sara", Salary=3000},
            new Employee{Name="Omar", Salary=4000}
        };
        var sorter = new SortingAlgorithm<Employee>();
        sorter.Sort(employees, (x, y) => x.Salary.CompareTo(y.Salary));
        Console.WriteLine("Employees sorted by salary:");
        foreach (var e in employees) Console.WriteLine($"{e.Name} - {e.Salary}");
        // Q: Benefit of generic sorting = reusable across any type → code reuse & type safety.

        // Problem 2: Sort Integers Descending using Lambda
        int[] numbers = { 1, 5, 3, 9, 2 };
        new SortingTwo<int>().Sort(numbers, (a, b) => b.CompareTo(a));
        Console.WriteLine("Numbers sorted descending:");
        Console.WriteLine(string.Join(",", numbers));
        // Q: Lambdas improve readability & flexibility by making sorting logic inline and concise.

        // Problem 3: Sort strings by length Ascending
        string[] words = { "apple", "hi", "banana", "car" };
        new SortingTwo<string>().Sort(words, (a, b) => a.Length.CompareTo(b.Length));
        Console.WriteLine("Strings sorted by length:");
        Console.WriteLine(string.Join(",", words));
        // Q: Dynamic comparer is important because objects of different types may require custom logic.

        // Problem 4: Manager implementing IComparable
        Manager[] managers = {
            new Manager{Name="Boss1", Salary=7000},
            new Manager{Name="Boss2", Salary=6000}
        };
        Array.Sort(managers);
        Console.WriteLine("Managers sorted by salary:");
        foreach (var m in managers) Console.WriteLine($"{m.Name} - {m.Salary}");
        // Q: IComparable<T> in derived classes allows defining custom comparison logic.

        // Problem 5: Func<T,T,bool> Compare by Name length
        Func<Employee, Employee, bool> compareByNameLen = (a, b) => a.Name.Length < b.Name.Length;
        var empList = employees.ToList();
        empList.Sort((a, b) => a.Name.Length.CompareTo(b.Name.Length));
        Console.WriteLine("Employees sorted by name length:");
        foreach (var e in empList) Console.WriteLine(e.Name);
        // Q: Built-in delegates like Func simplify generic programming by reducing boilerplate.

        // Problem 6: Anonymous function vs Lambda for integer sort Ascending
        int[] arr = { 4, 1, 7, 2 };
        Array.Sort(arr, delegate (int a, int b) { return a.CompareTo(b); });
        Array.Sort(arr, (a, b) => a.CompareTo(b));
        Console.WriteLine("Array sorted ascending: " + string.Join(",", arr));
        // Q: Anonymous functions are verbose, lambdas are shorter & more readable.

        // Problem 7: Generic Swap
        int x = 10, y = 20;
        SortingAlgorithm.Swap(ref x, ref y);

        Console.WriteLine($"x = {x}, y = {y}");
        // Q: Generic methods like Swap improve reusability for any type.

        // Problem 8: Multi-criteria sorting
        empList.Sort((a, b) => a.Salary != b.Salary ? a.Salary.CompareTo(b.Salary) : a.Name.CompareTo(b.Name));
        Console.WriteLine("Employees sorted by salary then name:");
        foreach (var e in empList) Console.WriteLine($"{e.Name} - {e.Salary}");
        // Q: Multi-criteria sorting adds complexity but increases flexibility and correctness.

        // Problem 9: GetDefault<T>
        Console.WriteLine($"Default int: {GetDefault<int>()}");
        Console.WriteLine($"Default string: {GetDefault<string>() ?? "null"}");
        // Q: default(T) gives 0 for value types, null for ref types.

        // Problem 10: Clone Employee array before sorting
        Employee[] cloned = employees.Select(e => (Employee)e.Clone()).ToArray();
        sorter.Sort(cloned, (a, b) => a.Salary.CompareTo(b.Salary));
        Console.WriteLine("Cloned employees sorted:");
        foreach (var e in cloned) Console.WriteLine(e.Name);
        // Q: Constraints ensure type safety (only ICloneable types allowed).

        // Problem 11: Delegate string transformation
        Func<string, string> transformer = s => s.ToUpper();
        List<string> names = new List<string> { "hello", "world" };
        var upper = TransformList(names, transformer);
        Console.WriteLine("Uppercased: " + string.Join(",", upper));
        // Q: Delegates enable functional style and flexibility.

        // Problem 12: Delegate int operation
        Func<int, int, int> op = (a, b) => a + b;
        Console.WriteLine("Add: " + Operate(5, 3, op));
        // Q: Delegates allow plugging different operations easily.

        // Problem 13: Generic delegate transform
        var result = Transform<int, string>(new List<int> { 1, 2, 3 }, i => i.ToString());
        Console.WriteLine("Transformed to strings: " + string.Join(",", result));
        // Q: Generic delegates allow flexible data transformations.

        // Problem 14: Func<int,int> square
        Func<int, int> square = n => n * n;
        var squares = ApplyFunc(new List<int> { 2, 3, 4 }, square);
        Console.WriteLine("Squares: " + string.Join(",", squares));
        // Q: Func simplifies delegate usage.

        // Problem 15: Action<string> print
        Action<string> print = s => Console.WriteLine($"String: {s}");
        ApplyAction(new List<string> { "a", "b" }, print);
        // Q: Action is used for side effects without return values.

        // Problem 16: Predicate<int> even filter
        Predicate<int> isEven = n => n % 2 == 0;
        var evens = Filter(new List<int> { 1, 2, 3, 4 }, isEven);
        Console.WriteLine("Evens: " + string.Join(",", evens));
        // Q: Predicates clarify boolean conditions in functional code.

        // Problem 17: Anonymous function filter strings
        var filtered = FilterStrings(new List<string> { "apple", "cat", "car" }, delegate (string s) { return s.StartsWith("c"); });
        Console.WriteLine("Strings start with c: " + string.Join(",", filtered));
        // Q: Anonymous functions allow modular ad-hoc conditions.

        // Problem 18: Anonymous function math operation
        Func<int, int, int> multiply = delegate (int a, int b) { return a * b; };
        Console.WriteLine("Multiply: " + multiply(4, 5));
        // Q: Use anonymous functions for quick throwaway logic.

        // Problem 19: Lambda filter strings
        var lambdaFiltered = FilterStrings(new List<string> { "apple", "bee", "sun" }, s => s.Length > 3 && s.Contains("e"));
        Console.WriteLine("Filtered: " + string.Join(",", lambdaFiltered));
        // Q: Lambdas make functional code concise and expressive.

        // Problem 20: Lambda math on doubles
        Func<double, double, double> power = (a, b) => Math.Pow(a, b);
        Console.WriteLine("2^3= " + power(2, 3));
        // Q: Lambdas enhance expressiveness of computations.
    }

    // Helper Methods
    static T GetDefault<T>()
    {
        return default(T);
    }

    static List<string> TransformList(List<string> input, Func<string, string> func)
    {
        return input.Select(func).ToList();
    }

    static int Operate(int a, int b, Func<int, int, int> operation)
    {
        return operation(a, b);
    }

    static List<R> Transform<T, R>(List<T> list, Func<T, R> func)
    {
        return list.Select(func).ToList();
    }

    static List<int> ApplyFunc(List<int> list, Func<int, int> func)
    {
        return list.Select(func).ToList();
    }

    static void ApplyAction(List<string> list, Action<string> action)
    {
        foreach (var s in list) action(s);
    }

    static List<int> Filter(List<int> list, Predicate<int> pred)
    {
        return list.Where(n => pred(n)).ToList();
    }

    static List<string> FilterStrings(List<string> list, Func<string, bool> condition)
    {
        return list.Where(condition).ToList();
    }

}
