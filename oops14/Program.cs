using System;

namespace MethodOverridingDemo
{
    class Payment
    {
        public virtual void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing general payment of {amount:C}.");
        }
    }

    class CreditCardPayment : Payment
    {
        
        private void ValidateCreditCard()
        {
            Console.WriteLine("Credit Card validated.");
        }

        //overridded ProcessPayment fxn
        public override void ProcessPayment(double amount)
        {
            ValidateCreditCard();
            Console.WriteLine($"Processing credit card payment of {amount:C}.");
        }

        
    }

    class PayPalPayment : Payment
    {

        
        private void AuthenticatePayPal()
        {
            Console.WriteLine("Authenticated with PayPal.");
        }

        //overrridden ProcessPymentfxn fxn
        public override void ProcessPayment(double amount)
        {
            AuthenticatePayPal();
            Console.WriteLine($"Processing PayPal payment of {amount:C}.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            //creating instances of derived class using base calss interface
            Payment general = new Payment();
            Payment credit = new CreditCardPayment(); // base reference, derived object
            Payment paypal = new PayPalPayment();     // base reference, derived object

            //creating instances of derived class directly and then calling the overridden fxn -> this also works.
            PayPalPayment p = new PayPalPayment();
            p.ProcessPayment(567.98);

            // general.ProcessPayment(100.00); //calls base method as the object is of abse type
            // credit.ProcessPayment(200.00); // Calls overridden method as the object type is of CreditCard Class.
            // paypal.ProcessPayment(300.00); // Calls overridden method
        }
    }
}
