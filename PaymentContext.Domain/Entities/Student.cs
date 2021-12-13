using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            if(firstName.Length == 0) //validação
            {
              throw new Exception("Nome invalido");
            }
        }

      public string FirstName {get; private set; } //private está nas propriedades para somente o Student vai poder mudar-los
      public string LastName {get; private set; }
      public string Document {get; private set; }
      public string Email {get; private set; }
      public string Address { get; private set; } //endereço de entrega
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