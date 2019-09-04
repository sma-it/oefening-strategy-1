using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.Accounts
{
    class NoAccount : Account
    {
        public NoAccount(string name) : base(name)
        {
            paymentMethod = new PaymentMethods.NoPayment();
        }
    }
}
