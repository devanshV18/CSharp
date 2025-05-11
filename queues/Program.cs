using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> orders = new Queue<string>();

        orders.Enqueue("Order1");
        orders.Enqueue("Order2");

        //before dequeue
        Console.WriteLine(orders.Peek());

        Console.WriteLine(orders.Dequeue()); // Order1
        
        Console.WriteLine(orders.Peek());    // Order2
    }
}
