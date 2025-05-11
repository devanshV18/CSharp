using System;

namespace PropertyDemo
{
    class Employee
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    Console.WriteLine("Salary can't be negative!");
            }
        }

        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Salary = 50000; // valid
            Console.WriteLine("Salary: " + e.Salary);

            e.Salary = -100; // invalid, triggers error
        }
    }
}
