using System;

namespace oops6{
    class Car
{
  private string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model); // This will cause an error because model is private
  }
}
}