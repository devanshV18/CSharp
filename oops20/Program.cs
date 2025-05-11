using System;

namespace MethodOverridingExample
{
    // Base class
    class Animal
    {
        // A virtual method in the base class
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Overriding the Speak method in the derived class
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Another derived class
    class Cat : Animal
    {
        // Overriding the Speak method in the derived class
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // In this case we are Creating instances of derived classes using a base class interface, this also works perfectly fine.
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            //this also will work, as we have overridden the function, so it calls the concerned class function
            // Dog myDog = new Dog();
            // Cat mycat = new Cat();

            // Calling the overridden method
            myDog.Speak();  // Output: Dog barks
            myCat.Speak();  // Output: Cat meows
        }
    }
}
