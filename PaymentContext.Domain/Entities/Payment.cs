using System;

namespace PaymentContext.Domain.Entities
{
   abstract public class Payment
   {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string document, string payer, string address, string email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper(   );
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            this.document = document;
            Payer = payer;
            Address = address;
            Email = email;
        }

     public string Number { get; private set; }
     public DateTime PaidDate { get; private set; } //data de pagamento
     public DateTime ExpireDate { get; private set; }
     public decimal Total { get; private set; }
     public decimal TotalPaid { get; private set; }
     public string document { get; private set; }
     public string Payer { get; private set; }
     public string Address { get; private set; } //endereço de cobrança
     public string Email { get; private set; }
   }

}