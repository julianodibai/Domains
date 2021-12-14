using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
   public class Name : ValueObject
   {
      public Name(string firstName, string lastName) 
      {
         FirstName = firstName;
         LastName = lastName;          
      }

      public string FirstName {get; private set; } //private está nas propriedades para somente o Student vai poder mudar-los
      public string LastName {get; private set; }
   }
}