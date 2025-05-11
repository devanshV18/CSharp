using System;

namespace MethodDemo{
    class Greet{
        public void sayHello(){
            Console.WriteLine("Hello");
        }

        public int add(int a, int b){
            return a+b;
        }

        public void Show()
        {
            Console.WriteLine("No parameters.");
        }

        public void Show(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        public void Show(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        static void Main(string[] args){
            Greet g = new Greet();
            g.sayHello();
            int res = g.add(5,10);
            Console.WriteLine(res);
            g.Show(5);
            g.Show("Yo!");
        }
    }
}