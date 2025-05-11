using System;
using System.Text;

namespace StringConceptsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // ✅ 1. String Basics
            string sentence = " Hello, C# World! ";

            // Trim whitespace -> removes all leading and trailing whitespaces.
            string trimmed = sentence.Trim();
            Console.WriteLine("Trimmed: " + trimmed);

            // Convert to uppercase
            Console.WriteLine("Uppercase: " + trimmed.ToUpper());

            // Replace words
            string replaced = trimmed.Replace("C#", "CSharp");
            Console.WriteLine("Replaced: " + replaced);

            // Check if contains a word
            Console.WriteLine("Contains 'World'? " + replaced.Contains("World"));

            // Index of a word
            Console.WriteLine("Index of 'World': " + replaced.IndexOf("World")); //returns indexof first letter of the argumnment word

            // Extract substring (from index 7, length 6)
            string sub = replaced.Substring(7, 6); //starts from index 7, i.e first character is index 7 and moves till 6 more characters.
            Console.WriteLine("Substring: " + sub);

            // Split string into words
            string[] words = replaced.Split(' '); //creates an array by splitting the string into words at argumented characters.
            Console.WriteLine("Words:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(new string('-', 40));

            // ✅ 2. StringBuilder vs string
            string normalConcat = "";
            for (int i = 0; i < 5; i++)
            {
                normalConcat += i + " "; // creates new string each time (inefficient) -> add (i + " ") into normal concat
            }
            Console.WriteLine("Using string: " + normalConcat);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                sb.Append(i + " "); // appends to same memory (efficient)
            }
            Console.WriteLine("Using StringBuilder: " + sb.ToString());

            Console.WriteLine(new string('-', 40));

            // ✅ 3. String Interpolation
            string name = "Devansh";
            int age = 22;
            Console.WriteLine($"👋 Hello, my name is {name} and I am {age} years old.");

            // Can also do inline expressions
            Console.WriteLine($"Next year I will be {age + 1}");

            Console.WriteLine(new string('-', 40));

            // ✅ 4. Escape Sequences
            Console.WriteLine("Escape Examples:");
            Console.WriteLine("Line 1\nLine 2");
            Console.WriteLine("Column1\tColumn2\tColumn3");
            Console.WriteLine("She said: \"Learning C# is fun!\"");
            Console.WriteLine("Path: C:\\Users\\Devansh\\Documents");

            Console.WriteLine(new string('-', 40));

            string[] headers = { "Name", "Age", "Country" };
            string[] data = { "Devansh", "23", "India" };

            StringBuilder csv = new StringBuilder();

            // Add header row
            // the below line -> string.Join(",", headers) merges the headers array to a single comma separated string 
            csv.AppendLine(string.Join(",", headers));

            Console.WriteLine(csv.ToString()); //Name,Age,Country + an empty line

            // same is done here for data array
            csv.AppendLine(string.Join(",", data)); //appends data arrray in a comma separated string format to csv.

            Console.WriteLine(csv.ToString()); //prints complete string.
 
            Console.WriteLine("✅ All string concepts demonstrated successfully!");
        }
    }
}
