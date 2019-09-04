using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.PaymentMethods
{
    interface IPaymentMethod
    {
        string Name { get; }
        float TransactionFee { get; }

        bool RequestPayment(float amount);
    }
}
