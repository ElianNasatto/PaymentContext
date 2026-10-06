using PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var student = new Student("Elian", "Nasatto", "123.456.789-10", "Elian@feesc.org.br");
            foreach (var item in student.Notifications)
                Console.WriteLine(item.Message);
        }
    }
}
