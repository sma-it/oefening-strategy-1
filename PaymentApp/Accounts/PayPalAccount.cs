using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.Accounts
{
    class PayPalAccount : Account
    {
        public PayPalAccount(string name) : base(name)
        {
            paymentMethod = new PaymentMethods.PayPalPayment();
        }
    }
}
