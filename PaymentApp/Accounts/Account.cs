using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp
{
    abstract class Account
    {
        private string name;
        public string Name { get => name; }

        private int items = 0;
        public int Items { get => items; }

        private float saldo = 100;
        public float Saldo { get => saldo; }

        protected PaymentMethods.IPaymentMethod paymentMethod;
        public PaymentMethods.IPaymentMethod PaymentMethod { get => paymentMethod; }

        public Account(string name)
        {
            this.name = name;
        }

        public bool BuyItem()
        {
            if (Saldo >= 5 + paymentMethod.TransactionFee && paymentMethod.RequestPayment(5))
            {
                saldo -= 5 + paymentMethod.TransactionFee;
                items++;
                return true;
            }
            return false;
        }
    }
}
