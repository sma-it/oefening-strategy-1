using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.PaymentMethods
{
    class NoPayment : IPaymentMethod
    {
        private string name = "None";
        public string Name { get => name; }

        private float transactionFee = 0.00f;
        public float TransactionFee { get => transactionFee; }

        public bool RequestPayment(float amount)
        {
            Console.WriteLine("No Valid Payment System");
            return false;
        }
    }
}
