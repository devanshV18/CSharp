using System;

namespace MathFunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Devansh";
            string lastName = "Verma";

            //length
            Console.WriteLine("Length of first Name is " + firstName.Length);

            //ToUpper and ToLower
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToLower());

            //concatenation
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //concatenation with string function
            string fullName2 = string.Concat(firstName, lastName);
            Console.WriteLine(fullName2);

            //misc concat
            string fullName3 = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName3);
            
            //concat in case on numbers
            int num = 5;
            float num2 = 5.678f;
            // int sum = num + num2; the sum wont be stores in int as its an explicit conversion, we need to convert it to int explicitly first
            int sum = num + (int)num2;
            Console.WriteLine(sum);

            //using float to store sum will obviously work as its explicit conversion and storage of values.

            //string Interpolation
            string teamName = "RCB";
            string homeGround = "Chinnaswamy Stadium";

            //interpoaltion using $
            string message = $"The {teamName} team plays at {homeGround}";
            Console.WriteLine(message);

            //accessing string characters - index start at 0
            string myString = "Hello";
            Console.WriteLine(myString[0]);

            //extracting index
            string myString2 = "Hello";
            Console.WriteLine(myString2.IndexOf("e"));

            //special cahracters
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);

            string url = "https:\\www.example.com";
            Console.WriteLine(url);

            string txt3 = "It\'s alright.";
            Console.WriteLine(txt3);

        }
    }
}
