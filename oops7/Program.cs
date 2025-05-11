using System;

namespace PropertyDemo
{
    class Person
    {
        private string name; // private field

        public string Name // Property
        {
            get { return name; } // getter
            set { name = value; } // setter
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Devansh"; // uses the set accessor
            Console.WriteLine("Name: " + p.Name); // uses the get accessor
        }
    }
}
