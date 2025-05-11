using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

        fruits.Add("Mango");
        fruits.Remove("Banana");

        Console.WriteLine("Fruits:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(fruits.Contains("Apple"));

        Console.WriteLine($"Total fruits: {fruits.Count}");
    }
}
