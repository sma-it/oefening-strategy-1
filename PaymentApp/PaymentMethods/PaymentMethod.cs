using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.PaymentMethods
{
    class PaymentMethod
    {
        private string name = "Visa";
        public string Name { get => name; }

        private float transactionFee = 0.20f;
        public float TransactionFee { get => transactionFee; }

        public bool RequestPayment(float amount)
        {
            // visa needs a 3 number CCV code for verification
            Console.Write("Enter your CCV Code: ");
            string code = Console.ReadLine();

            // assume the code is 123
            if (code.Equals("123")) return true;
            return false;
        }
    }
}
