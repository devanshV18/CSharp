using System;

namespace StructExample
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point is at ({X}, {Y})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = p1;
            p2.X = 100;

            p1.Display(); // (10, 20)
            p2.Display(); // (100, 20) , because p2 has a copy of p1 so only p2 changed upon p2.X = 100.
        }
    }
}
