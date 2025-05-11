using System;

namespace MethodExamples
{
    class RefDemo
    {
        public void AddTen(ref int x)
        {
            x += 10;
        }

        public void GetValues(out int a, out string b)
        {
            a = 10;
            b = "Hello";
        }


        //name parameters
         public void BookTicket(string name, string destination = "Delhi", int seats = 1)
        {
            Console.WriteLine($"Name: {name}, Destination: {destination}, Seats: {seats}");
        }

        //recursive function

        public int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        //static vs non static

        public static void ShowStatic()
        {
            Console.WriteLine("Static method called.");
        }

        public void ShowNonStatic()
        {
            Console.WriteLine("Instance method called.");
        }


        static void Main(string[] args)
        {
            int number = 5;
            RefDemo demo = new RefDemo();
            demo.AddTen(ref number);
            Console.WriteLine("After ref: " + number); // 15
            demo.GetValues(out int x, out string y);
            Console.WriteLine("Out values: " + x + ", " + y); // 10, Hello

            demo.BookTicket("Devansh"); //destination and seats will take default values
            demo.BookTicket("Devansh", "Mumbai"); //seats will take default value
            demo.BookTicket("Devansh", "Mumbai", 3); //all values provided

            //named parameters -> improves readability - very good practice.
            demo.BookTicket(name: "Devansh", destination: "Baramulla"); //seats will take default value

            int fac = demo.Factorial(5);
            Console.WriteLine(fac);

            RefDemo.ShowStatic();
            demo.ShowNonStatic();
        }
    }
}
