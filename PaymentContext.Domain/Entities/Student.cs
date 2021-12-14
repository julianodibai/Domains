using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions; //cria uma Interface List(subs) que vai ter o (sub) como itens

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Email = email;
            _subscriptions = new List<Subscription>();

        }

      public Name Name {get; private set; } //private está nas propriedades para somente o Student vai poder mudar-los
      public Document document {get; private set; }
      public Email Email {get; private set; }
      public Address Address { get; private set; } //endereço de entrega
      public IReadOnlyCollection<Subscription> Subscriptions {get{return _subscriptions.ToArray(); } } //substitui o list por IRead para nao poder usar o Add()

      public void AddSubscription(Subscription subscription)
      {
        //se já estiver uma assinatura ativa, cancela

        //cancela todas as outras assinaturas, e coloca esta como principal
        foreach (var sub in Subscriptions)
        {
            sub.Inactivate();
        }
        _subscriptions.Add(subscription);
      }

    }
}