using System;

namespace variables{
    
    class Program{
        static void Main(string[] args){
            int age = 21;
            float num2 = 5.678f;
            double num3 = 5.6789123;
            string name = "Devansh Verma";
            char c = 'a';
            bool isTrue = false;

            // /comma decalration

            int x = 5, y = 6, z = 7;
            Console.WriteLine(x+y+z);

            //concatenation
            Console.WriteLine("My name is " + name + " " + "and my age is " + age);

            Console.WriteLine(isTrue);
        }
    } 
}