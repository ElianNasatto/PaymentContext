using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string lastTransactionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Adress adress, Email email) : base(paidDate, expireDate, total, totalPaid, payer, document, adress, email)
        {
            LastTransactionCode = lastTransactionCode;
        }

        public string LastTransactionCode { get; set; }

    }
}
