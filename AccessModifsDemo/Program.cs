//NOTE THIS FILE HAS MULTIPLE MAIN FUNCTION AND WE CAN ONLY RUN ONE MAIN FUNCTION, I.E. ONE ENTRY POINT AT A TIME.
//INORDER TO RUN THIS FILE ->
// 1. EITHER COMMENT OUT THE OTHER MAIN FUNCTION OR DELETE THEM, AND MAKE SURE ONLY ONE MAIN FUNCTION IS LEFT.
// 2. csc Program.cs -main:Program1 

using System;

namespace AccessModifierDemo
{
    // By default, this class is 'internal' — accessible only within the same assembly
    class Demo
    {
        public void Greet()
        {
            Console.WriteLine("Hello from Demo!");
        }

        private void Secret()
        {
            Console.WriteLine("This is secret.");
        }
    }

    class Other
    {
        public void Call()
        {
            Demo d = new Demo();    // ✅ 'Demo' is accessible because it's internal by default and we're in the same assembly
            d.Greet();              // ✅ Public method, accessible from anywhere
            // d.Secret();         // ❌ Error: 'Secret' is private, accessible only within Demo
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Other other = new Other();
            other.Call(); // This will call the public Greet() method inside Demo
        }
    }
}
