//basic oops code structure for c# 

using System;

namespace oopsone{
    class Car{
        public string color = "red";

        // static void Main(string[] args){
        //     Car myObj = new Car();
        //     Console.WriteLine(myObj.color);
        // }
    }

    class Owner{
        string License = "BR01BW8695";

    }

    class Program{
        static void Main(string[] args){
            Car obj = new Car();
            Console.WriteLine("inside driver class " + obj.color);
        }
    }

    //KEY POINTS :- 
    // 1. We used a public variable color from the Car class in the Program class.
    // We could create an object of the Car class in the Program class and access the color variable as the default access modifier of class is internal, if we change it to public, it still works.
    //3 . NOTE -> Top level classes are not allowed to be private or protected.

    // Why is this?
    // Think of it like this:

    // The compiler must know what classes exist in a project in order to compile and use them correctly.

    // If a top-level class were private or protected, it would be invisible outside its own file or class, which defeats the purpose of a top-level class.


}