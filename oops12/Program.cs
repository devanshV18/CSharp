using System;

namespace InheritanceExample
{
    sealed class FinalClass
    {
        public void Show()
        {
            Console.WriteLine("Sealed class - cannot be inherited.");
        }
    }

    // class SubClass : FinalClass {} ❌ Error: Cannot derive from sealed class

    class Program
    {
        static void Main(string[] args)
        {
            FinalClass f = new FinalClass();
            f.Show();
        }
    }
}
