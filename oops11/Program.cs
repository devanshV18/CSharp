using System;

namespace oops11ConstructorChaining{
    class Person{
        public string name;

        public Person(){
            Console.WriteLine("Base class non parameterized constructor called");
        }

        public Person(string Name){
            this.name = Name;
            Console.WriteLine("Base class parameterised Constructor called");
        }
    }

    class Student : Person{
        public int rollNo;

        public Student() : base(){
            Console.WriteLine("Student class non parameterised constructor called");
        }

        public Student(string Name, int Rollno) : base(Name){
            this.rollNo = Rollno;
            Console.WriteLine("Student class parameterised constructor called");
        }

        public void Display(){
            Console.WriteLine($"The name is {name} and Roll number is {rollNo}");
        }
    }

    class Program{
        static void Main(string[] args){
            
            //snippet 1 (comment all other snippets)

            //snippet exp - we call the student class non parameterised constructor , hence it calls the non parameterised constructor of person class first. and then we manually add values and display it.

            // Student s = new Student(); 
            // s.name = "Devansh Verma";
            // s.rollNo = 22;
            // s.Display();

            //snippet 2 (Comment all other snippts)
            Student s = new Student("Devansh", 21);
            s.Display();
        }
    }
}



