using System;

namespace MultipleInterfaces
{
    interface IPrintable
    {
        void Print();
    }

    interface IScannable
    {
        void Scan();
    }

    class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MultiFunctionPrinter mfp = new MultiFunctionPrinter();
            mfp.Print();
            mfp.Scan();
        }
    }
}
