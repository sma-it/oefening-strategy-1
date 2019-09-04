using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.PaymentMethods
{
    class PayPalPayment : IPaymentMethod
    {
        private string name = "Paypal";
        public string Name { get => name; }

        private float transactionFee = 0.50f;
        public float TransactionFee { get => transactionFee; }

        public bool RequestPayment(float amount)
        {
            // paypal needs a password for verification
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // assume the password is 'password'
            if (password.Equals("password")) return true;
            return false;
        }
    }
}
