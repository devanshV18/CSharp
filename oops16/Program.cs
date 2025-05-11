using System;

abstract class Animal
{
    public string color;

    //constructor
    public Animal(string color){
        this.color = color;
    }
    public abstract void MakeSound(); // Abstract method (no body)
    
    public void Sleep() // Regular method with body
    {
        Console.WriteLine("Sleeping...");
    }
}

class Dog : Animal
{
    public int age;

    public Dog(string color, int age) : base(color){
        this.age = age;
    }
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Program
{
    static void Main()
    {
        //this works fine, as the abstract method simply g
        Dog d = new Dog("golden", 4);
        d.MakeSound(); // Output: Bark
        d.Sleep();     // Output: Sleeping...

        //using absract class interface -> this again works too
        Animal a = new Dog("White", 5);
        a.MakeSound();
        d.Sleep();
    }
}
