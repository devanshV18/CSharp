using System;

namespace TryCatchExample
{
    // building a custom exception class to handle and throw our custom exceptions
    // we are creating a public InvalidMarksException class that extends Exception built-in class
    public class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message) { }
    }

    class Program
    {
        public int marks;

        public void setMarks(int marks)
        {
            if (marks < 0 || marks > 100)
            {
                throw new InvalidMarksException("Invalid Marks");
            }
            this.marks = marks; // fixed incorrect property access
        }

        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("Age must be over 18!"); // ArgumentException is a built-in .NET exception
            }
        }

        static void Main(string[] args)
        {
            // 1. basic try catch error handling example. -> Automatic builtin exception thrown by the compiler.
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
                Console.WriteLine(result);
                // try block throws an built-in exception object of type DivideByZeroException
            }
            catch (DivideByZeroException e) // the DivideByZeroException is caught here and handled gracefully.
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine(e.Message); // The actual exception thrown by try is 'e' object from which we are extracting message.
            }
            finally
            {
                Console.WriteLine("Finally block executed."); // No matter if try executes successfully or we handle an error in catch, finally always executes.
            }

            // 2. Manual exception throwing (throw keyword) -> instead of automatic exception throws being handled in catch, in this case we throw an exception manually, but the type of exception is a built-in type only.
            // ArgumentException is a built-in .NET exception which we throw manually giving us more granular and line-wise control to decide the exact point at which we want to throw an exception.
            try
            {
                checkAge(15);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Caught Exception: " + e.Message);
            }

            // 3. Custom exceptions
            Program p = new Program();
            try
            {
                p.setMarks(150); // Invalid value to trigger our custom exception
            }
            catch (InvalidMarksException e)
            {
                Console.WriteLine("Custom Error Caught: " + e.Message);
            }

            Console.WriteLine("Program continues...");
        }
    }
}
