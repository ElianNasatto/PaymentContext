using PaymentContext.Domain.Entities.Enums;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document: ValueObject
    {
        public Document(string document,EDocumentType type)
        {
            Number = document;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type{ get; set; }
    }
}
