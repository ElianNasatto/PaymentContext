using Flunt.Notifications;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
            
            AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public Adress Adress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            //Se já tiver uma assinatura ativa, cancela

            //Cancela todas as outras e coloca esta como principal
            foreach (var sub in Subscriptions)
                sub.Inactivate();

            _subscriptions.Add(subscription);
        }
    }
}
