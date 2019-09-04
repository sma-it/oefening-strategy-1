using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.Accounts
{
    class VisaAccount : Account
    {
        public VisaAccount(string name) : base(name)
        {
            paymentMethod = new PaymentMethods.VisaPayment();
        }
    }
}
