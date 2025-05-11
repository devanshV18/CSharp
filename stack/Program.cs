using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> pages = new Stack<string>();

        pages.Push("Home");
        pages.Push("About");

        Console.WriteLine(pages.Pop());  // About
        Console.WriteLine(pages.Peek()); // Home
    }
}
