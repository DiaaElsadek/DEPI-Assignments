using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_02
{
    class SortingUtility
    {

        public static void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                        minIndex = j;
                }
                
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
        }

        public static void Run()
        {
            int[] areas = { 25, 78, 50, 12 };
            SelectionSort(areas);

            Console.WriteLine("\nAreas sorted using SelectionSort:");
            foreach (var area in areas)
                Console.WriteLine(area);
        }

    }
}
