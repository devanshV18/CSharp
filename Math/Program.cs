using System;

namespace MathFunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = -9.25;
            double positive = Math.Abs(number);
            double squareRoot = Math.Sqrt(16);
            double power = Math.Pow(2, 3);     // 2 raised to the power 3
            double ceiling = Math.Ceiling(4.3);
            double floor = Math.Floor(4.7);
            double rounded = Math.Round(4.5);
            double max = Math.Max(10, 20);
            double min = Math.Min(10, 20);

            Console.WriteLine("Absolute: " + positive);
            Console.WriteLine("Square Root: " + squareRoot);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("Ceiling: " + ceiling);
            Console.WriteLine("Floor: " + floor);
            Console.WriteLine("Rounded: " + rounded);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }
    }
}
