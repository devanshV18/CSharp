using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> languages = new HashSet<string>
        {
            "C#", "Java", "Python", "C#"
        };

        languages.Add("Go");

        foreach (var lang in languages)
        {
            Console.WriteLine(lang); // C# printed only once
        }
    }
}
