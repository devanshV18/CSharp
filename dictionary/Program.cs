using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a dictionary to store student roll numbers and names
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Adding entries using indexer syntax
        students[101] = "Devansh";
        students[102] = "Ravi";

        // Iterating through the dictionary and printing key-value pairs
        foreach (var pair in students)
        {
            Console.WriteLine($"Roll: {pair.Key}, Name: {pair.Value}");
        }

        // Checking if a key exists in the dictionary
        if (students.ContainsKey(101))
        {
            Console.WriteLine("Student 101 exists.");
        }
    }
}
