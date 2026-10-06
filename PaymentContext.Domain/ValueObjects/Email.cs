using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string adress)
        {
            Adress = adress;
        }
        public string Adress { get; private set; }
    }
}
