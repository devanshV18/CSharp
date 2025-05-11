using System;

namespace PropertyDemo
{
    class Student
    {
        public int Age { get; set; } // auto-implemented property

        static void Main(string[] args)
        {
            Student s = new Student();
            s.Age = 21;
            Console.WriteLine("Student Age: " + s.Age);
        }
    }
}
