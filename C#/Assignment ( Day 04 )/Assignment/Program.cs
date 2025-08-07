using System;

namespace Assignment
{
    internal class Program
    {
        enum DayOfWeek
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
        static void Main(string[] args)
        {

            #region Part01

            #region Problem 1

            //// Problem -> Write a program that: 

            //// 1 - Initializes a one-dimensional array in three different ways (new int[size], initializer list, and Array syntax sugar). 

            //int[] degrees;

            //int[] degrees1 = new int[3];

            //int[] degrees2 = new int[3] { 10, 20, 30 };

            //int[] degrees3 = { 10, 20, 30 };

            //// 2 - Assigns values to each element in the array and prints them

            //degrees1[0] = 10;
            //degrees1[1] = 20;
            //degrees1[2] = 30;

            //Console.WriteLine($"The First Element of Degrees1 is {degrees1[0]}");
            //Console.WriteLine($"The Second Element of Degrees1 is {degrees1[1]}");
            //Console.WriteLine($"The Third Element of Degrees1 is {degrees1[2]}");

            //// 3 - Demonstrates an IndexOutOfRangeException. 

            //Console.WriteLine(degrees1[10]);

            //// Question

            ///*
            //    In C#, when you create an array, each element is automatically assigned a default value depending on its data type:

            //    1- For numeric types like int, long, etc., the default value is 0.

            //    2- For floating-point types like float, double, the default is 0.0.

            //    3- For bool, the default value is false.

            //    4- For char, the default value is the null character '\0'.

            //    5- For reference types like string or any object, the default value is null.

            // */

            #endregion

            #region Problem 2

            //// Problem -> Write a program that:

            //// 1 - Create two arrays (arr1 and arr2).

            //int[] arr1 = new int[3] { 1, 2, 3 };
            //int[] arr2 = new int[3] { 4, 5, 6 };

            //// 2 - Perform a shallow copy and demonstrate how modifying one affects the other.

            //Console.WriteLine(arr1[0]); // 1
            //Console.WriteLine(arr2[0]); // 4

            //arr2 = arr1;

            //arr1[0] = 10;

            //Console.WriteLine(arr1[0]); // 10
            //Console.WriteLine(arr2[0]); // 10

            //int[] copy = (int[])arr2.Clone();

            //Console.WriteLine(copy[0]); // 10
            //Console.WriteLine(arr2[0]); // 10

            //arr2[0] = 20;

            //Console.WriteLine(copy[0]); // 10
            //Console.WriteLine(arr2[0]); // 20

            //// Question: What is the difference between Array.Clone() and Array.Copy()?

            ///*

            // Array.Clone():

            //    Returns a shallow copy of the array.

            //    It creates a new array with the same length and copies all elements.

            //    If the array contains value types (like int), it works like a deep copy.

            //    But if the array contains reference types (like objects), only the references are copied — not the actual objects.

            //Array.Copy():

            //    Copies elements from one array to another existing array.

            //    You must create the destination array first.

            //    It allows you to copy specific ranges, not just the whole array.

            //    Like Clone(), it also performs a shallow copy.

            // */

            #endregion

            #region Problem 3

            //// Problem -> Write a program that:

            //// 1 - Create a 2D array with student grades (3 students, 3 subjects each). 

            //int[,] studentGrades = new int[3, 3];

            //// 2 - Take input from the user to fill the array. 

            //for(int i = 0; i < studentGrades.GetLength(0); i++)
            //{
            //    for(int j = 0; j < studentGrades.GetLength(1); /*j++*/)
            //    {
            //        Console.Write($"Enter the grade for Student {i + 1}, Subject {j + 1}: ");
            //        bool flag = int.TryParse(Console.ReadLine(), out studentGrades[i, j]);
            //        if (flag && studentGrades[i, j] >= 0 && studentGrades[i, j] <= 100) j++;
            //    }
            //}

            //// 3 - Print the grades for each student using nested loops.

            //for (int i = 0; i < studentGrades.GetLength(0); i++)
            //{
            //    Console.Write($"Grades for Student {i + 1}:\n");
            //    for (int j = 0; j < studentGrades.GetLength(1); j++)
            //    {
            //        Console.Write($"Subject {j+1} -> {studentGrades[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            //// Question: What is the difference between GetLength() and Length for multi dimensional arrays? 

            //// GetLength(dimension): returns number of elements in a specific dimension.
            //// For example: GetLength(0) => rows, GetLength(1) => columns

            //// Length: returns total number of elements in the whole array.
            //// For example: 3x4 array => Length = 12


            #endregion

            #region Problem 4

            //// Problem -> Write a program that:

            //// 1 - Demonstrates at least 5 array methods (Sort, Reverse, IndexOf, Copy, Clear).

            //int[] original = { 5, 3, 9, 1, 7 };

            //// Before Sort: array = { 5, 3, 9, 1, 7 }
            //Array.Sort(original); // Sorts the array in ascending order
            //// After Sort: array = { 1, 3, 5, 7, 9 }

            //// Before Reverse: array = { 1, 3, 5, 7, 9 }
            //Array.Reverse(original); // Reverses the array order
            //// After Reverse: array = { 9, 7, 5, 3, 1 }

            //// IndexOf: search for value 5 in the array
            //int index = Array.IndexOf(original, 5); // Returns the index of the first occurrence of 5
            //// Index of 5 = 2

            //// Copy: copy original array into a new one
            //int[] copiedArray = new int[original.Length];
            //Array.Copy(original, copiedArray, original.Length);
            //// copiedArray now contains the same values as original: { 9, 7, 5, 3, 1 }

            //// Clear: reset the first 2 elements of copiedArray to 0
            //Array.Clear(copiedArray, 0, 2);
            //// copiedArray after Clear = { 0, 0, 5, 3, 1 }

            //// Print results
            //Console.WriteLine("Original array:");
            //Console.WriteLine(string.Join(", ", original));

            //Console.WriteLine("\nCopied array after Clear:");
            //Console.WriteLine(string.Join(", ", copiedArray));

            //Console.WriteLine($"\nIndex of 5 in original array: {index}");

            //// Question: What is the difference between Array.Copy() and Array.ConstrainedCopy() ?

            //// Array.Copy(): fast, but if an error occurs, partial copy might happen.
            //// Array.ConstrainedCopy(): safer, if any error occurs, nothing is copied at all.

            #endregion

            #region Problem 5

            //// Problem -> Create a program that: 

            //// 1 - Uses a for loop to print all elements of a 1D array

            //int[] arr = new int[5] { 10, 20, 30, 40, 50 };

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Element at index {i} is {arr[i]}");
            //}

            //// 2 - Uses a foreach loop to print all elements of the same array.

            //foreach(int item in arr) { 
            //    Console.WriteLine($"Element is {item}");
            //}

            //// 3 - Uses a while loop to print all elements in reverse order.

            //int index = arr.Length - 1;
            //while(index >= 0)
            //{
            //    Console.WriteLine($"Element at index {index} is {arr[index]}");
            //    index--;
            //}

            //// Question: Why is foreach preferred for read-only operations on arrays?

            //// foreach is preferred for read-only operations on arrays
            //// because it provides cleaner syntax, avoids index errors,
            //// and prevents accidental modification of array elements.

            #endregion

            #region Problem 6

            //// Problem -> Write a program that:

            //// Repeatedly asks the user for a positive odd number.
            //// Uses defensive coding to validate input using int.TryParse and a do-while loop.

            //int num;
            //bool flag;

            //do
            //{

            //    Console.WriteLine("Enter a Positive Odd Number: ");
            //    flag = int.TryParse(Console.ReadLine(), out num); // if the input is int -> Num is true else Num is false

            //    if (flag && num % 2 != 0 && num > 0)
            //    {
            //        Console.WriteLine($"You entered a valid positive odd number: {num}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please try again.");
            //        flag = false; // reset flag to false to continue the loop
            //    }

            //} while (!flag); // while condition

            //// Question: Why is input validation important when working with user inputs?

            //// Input validation is important when working with user inputs
            //// because it prevents errors, crashes, and security vulnerabilities.
            //// It ensures the program only accepts expected and safe data.


            #endregion

            #region Problem 7

            //// Problem -> Write a program that:

            //// 1 - Create a 2D array with fixed values.

            //int[,] matrix = new int[3, 3] {
            //    { 1, 2, 3 }, // First row
            //    { 4, 5, 6 }, // Second row
            //    { 7, 8, 9 }  // Third row
            //};

            //// 2 - Print the array elements in a matrix format (rows and columns). 

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for(int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t"); // Print each element with a tab space
            //    }
            //    Console.WriteLine();
            //}

            //// Question: How can you format the output of a 2D array for better readability?

            //// You can format the output of a 2D array for better readability
            //// by using tabs (\t), consistent spacing, or string formatting.
            //// This helps align columns and makes the matrix easier to read.

            #endregion

            #region Problem 8

            //// Problem -> Write a program that:

            //// 1 - Asks the user to enter a month number. 

            //Console.WriteLine("Enter a month number : ");

            //// 2 - Uses an if-else statement to determine the month name.
            //int monthNumber;
            //bool isValid = int.TryParse(Console.ReadLine(), out monthNumber);
            //if(monthNumber == 1) {
            //    Console.WriteLine("January");
            //} else if(monthNumber == 2) {
            //    Console.WriteLine("February");
            //} else if(monthNumber == 3) {
            //    Console.WriteLine("March");
            //} else if(monthNumber == 4) {
            //    Console.WriteLine("April");
            //} else if(monthNumber == 5) {
            //    Console.WriteLine("May");
            //} else if(monthNumber == 6) {
            //    Console.WriteLine("June");
            //} else if(monthNumber == 7) {
            //    Console.WriteLine("July");
            //} else if(monthNumber == 8) {
            //    Console.WriteLine("August");
            //} else if(monthNumber == 9) {
            //    Console.WriteLine("September");
            //} else if(monthNumber == 10) {
            //    Console.WriteLine("October");
            //} else if(monthNumber == 11) {
            //    Console.WriteLine("November");
            //} else if(monthNumber == 12) {
            //    Console.WriteLine("December");
            //} else {
            //    Console.WriteLine("Invalid month number.");
            //}

            //// 3 - Uses a switch statement to perform the same task.

            //switch (monthNumber) {                 
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        break;
            //}

            //// Question: When should you prefer a switch statement over if-else?

            //// Use a switch statement instead of if-else
            //// when you are checking a single variable against multiple constant values.
            //// It makes the code cleaner, easier to read, and more efficient in some cases.

            #endregion

            #region Problem 9

            //// Problem -> Write a program that:

            //// 1 - Sort an array of integers using Array.Sort(). 

            //int[] arr = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

            //Console.WriteLine("unSorted Array");

            //// Display not sorted Array
            //for (int i = 0; i < arr.Length; i++) {
            //    Console.WriteLine($"Element at index {i} is {arr[i]}");
            //}

            //Array.Sort(arr); // Sorts the array in ascending order 

            //Console.WriteLine("Sorted Array");

            //// Display sorted Array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Element at index {i} is {arr[i]}");
            //}

            //// 2 - Search for a specific value using Array.IndexOf() and Array.LastIndexOf().

            //int[] numbers = { 4, 7, 2, 7, 9, 1, 7 };

            //// firstindex

            //int firstIndex = Array.IndexOf(numbers, 7); // Returns the index of the first occurrence of 7 ( Start from Left )

            //Console.WriteLine($"First index of 5 is {firstIndex}"); // 1

            //// lastindex

            //int lastIndex = Array.LastIndexOf(numbers, 4); // Returns the index of the last occurrence of 7 ( Start from Right )

            //Console.WriteLine($"Last index of 5 is {lastIndex}"); // 0

            //// Question: What is the time complexity of Array.Sort()?

            //// The time complexity of Array.Sort() is O(n log n) in the average and worst case.
            //// It uses a hybrid sorting algorithm (like QuickSort + InsertionSort or IntroSort).

            #endregion

            #region Problem 10

            //// Problem -> Write a program that:

            //// 1 - Creates an array of integers. 

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //// 2 - Uses a for loop to calculate and print the sum of all elements.

            //int sum = 0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i]; // Add each element to sum
            //}

            //Console.WriteLine($"The sum of array is : {sum}");

            //// 2 - Uses a foreach loop to calculate the same sum.

            //int sum1 = 0;

            //foreach(int item in numbers)
            //{
            //    sum1 += item; // Add each element to sum1
            //}

            //Console.WriteLine($"The sum of array is : {sum1}");

            //// Question: Which loop (for or foreach) is more efficient for calculating the sum of an array, and why?

            //// The for loop is slightly more efficient than foreach when calculating the sum of an array,
            //// because it avoids the overhead of the iterator used in foreach.
            //// However, the difference is minimal for small arrays and both are acceptable.

            #endregion

            #endregion

            #region Part02

            //// Question 2

            //Console.Write("Enter a number (1-7): ");
            //bool isValid = int.TryParse(Console.ReadLine(), out int input);

            //if (isValid && input >= 1 && input <= 7)
            //{
            //    input--; // Adjust for zero-based index
            //    string dayName = Enum.GetName(typeof(DayOfWeek), input);

            //    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayName);

            //    Console.WriteLine("The day is: " + day);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            //}

            //// What happens if the user enters a value outside the range of 1 to 7?

            //// If the user enters a value outside the range of 1 to 7,
            //// the input is considered invalid and a message is shown.
            //// This prevents Enum.Parse from throwing an error due to invalid enum casting.


            #endregion

        }

    }

}
