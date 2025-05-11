using System;

namespace TypeConversion{
    class Program {
        static void Main(string[] args){
            int myInt = 10;
            double myDouble = myInt; //automatic typecasiting -> Implicit

            double myDouble2 = 10.5;
            int myInt2 = (int)myDouble2; //manual typecasting -> Explicit 

            Console.WriteLine(myInt); 
            Console.WriteLine(myDouble); 

            Console.WriteLine(myDouble2); 
            Console.WriteLine(myInt2); 

            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


        }
    }
}