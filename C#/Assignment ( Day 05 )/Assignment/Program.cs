using System;
using System.Collections.Generic;

namespace Assignment
{
    internal class Program
    {

        

        static void Main(string[] args)
        {

            #region Part01

            #region Problem 1

            //// Problem

            //try
            //{
            //    Console.Write("Enter first integer: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter second integer: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine("Result: " + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero!");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}

            //// Question

            ///*
            //    Question: What is the purpose of the finally block?
            //    Answer: 
            //    The finally block is used to execute code regardless of whether an exception occurs or not. 
            //    It ensures that certain cleanup or final statements (like closing files, releasing resources, or showing a message) will always run.
            //*/

            #endregion

            #region Problem 2

            //// Problem

            //TestDefensiveCode();

            //// Question

            ///*
            //    Question: How does int.TryParse() improve program robustness compared to int.Parse()?
            //    Answer:
            //    - int.Parse() throws an exception if the input is invalid (non-numeric), which can crash the program if not handled.
            //    - int.TryParse() safely attempts to convert the input to an integer and returns 'true' or 'false' without throwing exceptions.
            //    - This prevents unnecessary crashes and allows the program to handle invalid inputs gracefully.
            //*/

            #endregion

            #region Problem 3

            //// Problem

            //int? number = null; // Nullable integer
            //// int number1 = null; // unNullable integer

            //// Using null-coalescing operator ?? to assign a default value if null
            //int result = number ?? 100;
            //Console.WriteLine("Result after ?? operator: " + result);

            //// Demonstrating HasValue
            //if (number.HasValue)
            //{
            //    Console.WriteLine("Number has a value: " + number.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Number is null, HasValue = false");
            //}

            //// Uncommenting the next line will cause an exception if number is null
            //// Console.WriteLine(number.Value);

            //// Question

            ///*
            //    Question: What exception occurs when trying to access Value on a null Nullable<T>?
            //    Answer:
            //    - It throws an InvalidOperationException with the message:
            //      "Nullable object must have a value."
            //*/

            #endregion

            #region Problem 4

            //// Problem

            //int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

            //try
            //{
            //    Console.WriteLine("Accessing element at index 10...");
            //    Console.WriteLine(numbers[10]); // Out of bounds
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //// Question

            ///*
            //    Question: Why is it necessary to check array bounds before accessing elements?
            //    Answer:
            //    - Accessing an index outside the array range causes an IndexOutOfRangeException.
            //    - Checking bounds ensures we only access valid indexes, preventing program crashes and unexpected behavior.
            //*/

            #endregion

            #region Problem 5

            //// Problem

            //int[,] matrix = new int[3, 3];

            //// Read values from user
            //Console.WriteLine("Enter values for a 3x3 matrix:");
            //for (int i = 0; i < matrix.GetLength(0); i++) // Rows
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Calculate and print sum of each row
            //Console.WriteLine("\nSum of each row:");
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        rowSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Row {i}: {rowSum}");
            //}

            //// Calculate and print sum of each column
            //Console.WriteLine("\nSum of each column:");
            //for (int j = 0; j < matrix.GetLength(1); j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        colSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Column {j}: {colSum}");
            //}

            //// Question

            ///*
            //    Question: How is the GetLength(dimension) method used in multi-dimensional arrays?
            //    Answer:
            //    - GetLength(dimension) returns the size of the array in the specified dimension.
            //    - For example, GetLength(0) gives the number of rows, and GetLength(1) gives the number of columns in a 2D array.
            //    - This makes loops more flexible and prevents hardcoding array sizes.
            //*/

            #endregion

            #region Problem 6

            //// Problem

            //// Create jagged array with 3 rows of varying sizes
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2]; // First row: 2 elements
            //jaggedArray[1] = new int[4]; // Second row: 4 elements
            //jaggedArray[2] = new int[3]; // Third row: 3 elements

            //// Populate each row with user input
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"Enter values for row {i + 1}:");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"Element [{i}][{j}]: ");
            //        jaggedArray[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Print all values row by row
            //Console.WriteLine("\nJagged Array Contents:");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //// Question

            ///*
            //    Question: How does the memory allocation differ between jagged arrays and rectangular arrays?
            //    Answer:
            //    - In rectangular arrays (e.g., int[3,4]), all elements are stored in a single continuous block of memory.
            //    - In jagged arrays (e.g., int[][]), each row is a separate array stored independently in memory, 
            //      meaning rows can have different lengths and are not stored contiguously.
            //*/

            #endregion

            #region Problem 7

            //// Problem

            //string? userName; // Nullable reference type

            //Console.Write("Enter your name (or press Enter to skip): ");
            //string input = Console.ReadLine();

            //// Assign value conditionally
            //if (!string.IsNullOrWhiteSpace(input))
            //{
            //    userName = input;
            //}
            //else
            //{
            //    userName = null;
            //}

            //// Using null-forgiveness operator (!) to suppress possible null warning
            //Console.WriteLine("Hello, " + userName!);

            //// Question

            ///*
            //    Question: What is the purpose of nullable reference types in C#?
            //    Answer:
            //    - Nullable reference types help developers write safer code by indicating whether a reference type can be null.
            //    - They enable the compiler to issue warnings when there’s a potential null reference, reducing the risk of NullReferenceException.
            //    - This improves code reliability and makes intent clearer.
            //*/

            #endregion

            #region Problem 8

            //// Problem

            //// Demonstrating Boxing
            //int number = 42;
            //object boxedNumber = number; // Boxing: value type → object
            //Console.WriteLine("Boxed value: " + boxedNumber);

            //// Demonstrating Unboxing
            //try
            //{
            //    int unboxedNumber = (int)boxedNumber; // Correct unboxing
            //    Console.WriteLine("Unboxed value: " + unboxedNumber);

            //    // Attempt invalid unboxing
            //    object strObject = "Hello";
            //    int invalidUnbox = (int)strObject; // This will throw InvalidCastException
            //    Console.WriteLine(invalidUnbox);
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine("Error during unboxing: " + ex.Message);
            //}

            //// Question

            ///*
            //    Question: What is the performance impact of boxing and unboxing in C#?
            //    Answer:
            //    - Boxing and unboxing involve extra processing because:
            //      1. Boxing allocates memory on the heap and copies the value type into it.
            //      2. Unboxing requires type checking and copying the value back to the stack.
            //    - This adds CPU overhead and increases garbage collection pressure, 
            //      so frequent boxing/unboxing should be avoided in performance-critical code.
            //*/

            #endregion

            #region Problem 9

            //// Problem

            //int a = 5, b = 3;
            //int sum, product;

            //SumAndMultiply(a, b, out sum, out product);

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Product: {product}");

            //// Question

            ///*
            //    Question: Why must out parameters be initialized inside the method?
            //    Answer:
            //    - out parameters are meant to return data from a method back to the caller.
            //    - The compiler requires them to be assigned a value inside the method before returning,
            //      to guarantee the caller always receives a valid initialized value.
            //*/

            #endregion

            #region Problem 10

            //// Problem

            //// Calling with both parameters
            //PrintString("Hello", 3);

            //// Calling with only the string (uses default for count)
            //PrintString("Default count example");

            //// Calling using named parameters
            //PrintString(count: 2, text: "Named parameters example");

            //// Question

            ///*
            //    Question: Why must optional parameters always appear at the end of a method's parameter list?
            //    Answer:
            //    - Optional parameters must be last so the compiler can correctly match arguments to parameters.
            //    - If they were in the middle, it would be unclear whether a passed value is for the optional parameter 
            //      or the next required parameter, causing ambiguity in method calls.
            //*/

            #endregion

            #region Problem 11

            //// Problem

            //int[]? numbers = null; // Nullable integer array

            //// Using null propagation operator to safely access Length
            //Console.WriteLine("Array length: " + (numbers?.Length ?? 0));

            //// Assign array and try again
            //numbers = new int[] { 1, 2, 3 };
            //Console.WriteLine("Array length: " + (numbers?.Length ?? 0));

            //// Question

            ///*
            //    Question: How does the null propagation operator prevent NullReferenceException?
            //    Answer:
            //    - The null propagation operator (?.) checks if the object is null before accessing its members.
            //    - If the object is null, the entire expression evaluates to null instead of throwing a NullReferenceException.
            //    - This allows safe access without the need for explicit null checks.
            //*/

            #endregion

            #region Problem 12

            //// Problem

            //Console.Write("Enter a day of the week: ");
            //string day = Console.ReadLine();

            //// Switch expression to map day to number
            //int dayNumber = day.ToLower() switch
            //{
            //    "saturday" => 1,
            //    "sunday" => 2,
            //    "monday" => 3,
            //    "tuesday" => 4,
            //    "wednesday" => 5,
            //    "thursday" => 6,
            //    "friday" => 7,
            //    _ => 0 // Default for invalid input
            //};

            //if (dayNumber != 0)
            //    Console.WriteLine($"Day number: {dayNumber}");
            //else
            //    Console.WriteLine("Invalid day entered.");

            //// Question

            ///*
            //    Question: When is a switch expression preferred over a traditional if statement?
            //    Answer:
            //    - A switch expression is preferred when:
            //      1. You have multiple possible constant values to match against a single variable.
            //      2. You want cleaner, more readable, and more concise code than multiple if-else blocks.
            //      3. Pattern matching or direct value mapping is needed without verbose syntax.
            //*/

            #endregion

            #region Problem 13

            //// Problem

            //// Calling with individual values
            //int sum1 = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine("Sum (individual values): " + sum1);

            //// Calling with an array
            //int[] numbers = { 10, 20, 30 };
            //int sum2 = SumArray(numbers);
            //Console.WriteLine("Sum (array): " + sum2);

            //// Question

            ///*
            //    Question: What are the limitations of the params keyword in method definitions?
            //    Answer:
            //    1. Only one params parameter is allowed in a method.
            //    2. It must be the last parameter in the method's parameter list.
            //    3. All arguments passed to it must be of the same type (or convertible to that type).
            //*/

            #endregion

            #endregion

            #region Part02

            #region Problem 1

            //// Problem

            //Console.Write("Enter a positive integer: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.Write(i);
            //        if (i < number) Console.Write(", ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a positive integer.");
            //}

            #endregion

            #region Problem 2

            //// Problem

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number * i);
            //    if (i < 12) Console.Write(", ");
            //}

            #endregion

            #region Problem 3

            //// Problem

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //bool firstPrinted = false; // for the spaces

            //for (int i = 2; i <= number; i += 2)
            //{
            //    if (firstPrinted)
            //        Console.Write(", ");
            //    Console.Write(i);
            //    firstPrinted = true;
            //}

            #endregion

            #region Problem 4

            //// Problem

            //Console.Write("Enter the base number: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //double result = 1;

            //for (int i = 1; i <= exponent; i++) {
            //    result *= baseNum;
            //}

            //Console.WriteLine($"Result: {result}");

            #endregion

            #region Problem 5

            //// Problem

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //char[] chars = input.ToCharArray();
            //Array.Reverse(chars);

            //string reversed = new string(chars);

            //Console.WriteLine($"Reversed string: {reversed}");

            #endregion

            #region Problem 6

            //// Problem

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //bool isNegative = number < 0;
            //number = Math.Abs(number);

            //char[] digits = number.ToString().ToCharArray();
            //Array.Reverse(digits);
            //string reversedStr = new string(digits);

            //int reversedNumber = int.Parse(reversedStr);
            //if (isNegative)
            //    reversedNumber *= -1;

            //Console.WriteLine($"Reversed integer: {reversedNumber}");

            #endregion

            #region Problem 7

            //// Problem

            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the array elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //// Dictionary to store the first occurrence of each element
            //Dictionary<int, int> firstIndex = new Dictionary<int, int>();

            //int maxDistance = -1;
            //int element = 0;
            //int startIndex = 0;
            //int endIndex = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if (!firstIndex.ContainsKey(arr[i]))
            //    {
            //        // First time seeing this element
            //        firstIndex[arr[i]] = i;
            //    }
            //    else
            //    {
            //        // Found same element again
            //        int distance = i - firstIndex[arr[i]] - 1;
            //        if (distance > maxDistance)
            //        {
            //            maxDistance = distance;
            //            element = arr[i];
            //            startIndex = firstIndex[arr[i]];
            //            endIndex = i;
            //        }
            //    }
            //}

            //if (maxDistance >= 0)
            //{
            //    Console.WriteLine($"Longest distance is {maxDistance} between element {element} at positions {startIndex} and {endIndex}.");
            //}
            //else
            //{
            //    Console.WriteLine("No repeating elements found.");
            //}

            #endregion

            #region Problem 8

            //// Problem

            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words));

            #endregion

            #endregion

        }

        // This Class For Problem 2 in Part01
        static void TestDefensiveCode()
        {
            int x, y;

            // Get positive integer for X
            while (true)
            {
                Console.Write("Enter a positive integer for X: ");
                if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            // Get positive integer for Y (must be greater than 1)
            while (true)
            {
                Console.Write("Enter a positive integer for Y (greater than 1): ");
                if (int.TryParse(Console.ReadLine(), out y) && y > 1)
                {
                    break;
                }
                Console.WriteLine("Invalid input! Please enter a number greater than 1.");
            }

            Console.WriteLine($"You entered X = {x}, Y = {y}");
        }

        // This Class For Problem 9 in Part01
        static void SumAndMultiply(int x, int y, out int sum, out int product)
        {
            sum = x + y;        // Must be assigned before method ends
            product = x * y;    // Must be assigned before method ends
        }

        // This Class For Problem 10 in Part01
        static void PrintString(string text, int count = 5)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(text);
            }
        }

        // This Class For Problem 13 in Part01
        static int SumArray(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

    }
}
