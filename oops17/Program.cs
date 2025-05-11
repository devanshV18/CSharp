using System;

namespace InterfaceExample
{
    // Interface definition
    interface IAnimal
    {
        void MakeSound();  // Method declaration
        void Eat(string food);  // Another method
    }

    // Class implementing the interface
    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Dog eats {food}.");
        }
    }

    // Another class implementing the same interface
    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cat says: Meow!");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Cat eats {food}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //interface class interface
            // IAnimal myDog = new Dog();
            // IAnimal myCat = new Cat();

            //concerned class interface
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            myDog.MakeSound();
            myDog.Eat("bones");

            myCat.MakeSound();
            myCat.Eat("fish");
        }
    }
}
