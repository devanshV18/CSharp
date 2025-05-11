using System;

namespace oops6{
    class Car{
  private string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car(); //we can still instantiate an object here outside car class because the default AM of classes in csharp is internal, public would also work?
    // Console.WriteLine(myObj.model); // This will cause an error because model is private
  }
}
}