using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderName, string cardNumber, string lastTrasactionNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, ValueObjects.Document document, Adress adress, Email email) : base(paidDate, expireDate, total, totalPaid, payer, document, adress, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTrasactionNumber = lastTrasactionNumber;
        }

        public string CardHolderName { get;private set; }
        public string CardNumber { get; private set; }
        public string LastTrasactionNumber { get; private set; }
    }
}
