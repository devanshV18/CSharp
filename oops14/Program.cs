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
            Payment general = new Payment();
            Payment credit = new CreditCardPayment(); // base reference, derived object
            Payment paypal = new PayPalPayment();     // base reference, derived object

            general.ProcessPayment(100.00);
            credit.ProcessPayment(200.00); // Calls overridden method
            paypal.ProcessPayment(300.00); // Calls overridden method
        }
    }
}
