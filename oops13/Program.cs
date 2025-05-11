using System;

namespace InheritanceExample
{
    class A
    {
        public string language;

        public A()
        {
            Console.WriteLine("Class A non-parameterised constructor");
        }

        public A(string language)
        {
            this.language = language;
            Console.WriteLine("Class A parameterised constructor called");
        }

        public void DisplayA()
        {
            Console.WriteLine("Class A concerns language");
        }
    }

    class B : A
    {
        public string accent;

        public B() : base()
        {
            Console.WriteLine("Class B non-parameterised constructor");
        }

        public B(string language, string accent) : base(language)
        {
            this.accent = accent;
            Console.WriteLine("Class B parameterised constructor");
        }

        public void DisplayB()
        {
            Console.WriteLine("Class B concerns accent");
        }
    }

    class C : B
    {
        public string region;

        public C() : base()
        {
            Console.WriteLine("Class C non-parameterised constructor");
        }

        public C(string language, string accent, string region) : base(language, accent)
        {
            this.region = region;
            Console.WriteLine("Class C parameterised constructor called");
        }

        public void DisplayC()
        {
            Console.WriteLine("Class C concerns region");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // snippet 1 -> Multilevel inheritance with non parameterised constructor.

            // C obj = new C();
            // //the object of class c can access functions from all classes as B has everything from A, C has everythin from B i.e A + B 
            // obj.DisplayA();
            // obj.DisplayB();
            // obj.DisplayC();

            //snippet 2 -> Multilevel inheritance with Parametrised constructor.
            C obj = new C("English", "British", "UK");
            obj.DisplayA();
            obj.DisplayB();
            obj.DisplayC();
        }
    }
}
