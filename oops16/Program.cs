using System;

namespace AbstractClassExample
{
    // Abstract base class
    abstract class Shape
    {
        public string Color { get; set; } 

        // Constructor
        public Shape(string color)
        {
            Color = color;
        }

        // Abstract method - must be overridden
        public abstract double Area();

        // Non-abstract method
        public void Display()
        {
            Console.WriteLine($"This is a {Color} shape.");
        }
    }

    // Derived class: Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        
        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }

        // Override abstract method
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        // Override abstract method
        public override double Area()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Shape s = new Shape("Red"); ❌ Not allowed - abstract class can't be instantiated

            Shape circle = new Circle("Blue", 5);
            Shape rect = new Rectangle("Green", 4, 6);

            circle.Display();
            Console.WriteLine($"Area of circle: {circle.Area():0.00}");

            rect.Display();
            Console.WriteLine($"Area of rectangle: {rect.Area():0.00}");

            // In Main, we declare references of type Shape, but assign them objects of type Circle and Rectangle
            //  This allows us to call methods like Display() and Area() polymorphically.
        }
    }
}
