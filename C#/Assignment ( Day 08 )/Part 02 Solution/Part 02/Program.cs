using System;

namespace Part_02
{
    class Program
    {

        public static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series.CurrentShapeArea);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Square Series:");
            Program.PrintTenShapes(new SquareSeries());

            Console.WriteLine("\nCircle Series:");
            Program.PrintTenShapes(new CircleSeries());

            ShapeSortingDemo.Run();

            GeometricShapeDemo.Run();

            SortingUtility.Run();

        }
    }
}
