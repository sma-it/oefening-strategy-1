using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp
{
    class Account
    {
        private string name;
        public string Name { get => name; }

        private int items = 0;
        public int Items { get => items; }

        private float saldo = 100;
        public float Saldo { get => saldo; }

        private PaymentMethods.PaymentMethod paymentMethod;
        public PaymentMethods.PaymentMethod PaymentMethod { get => paymentMethod; }

        public Account(string name)
        {
            this.name = name;
            paymentMethod = new PaymentMethods.PaymentMethod();
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
