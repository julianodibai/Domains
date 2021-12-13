using System;

namespace PaymentContext.Domain.Entities
{
   abstract public class Payment
   {
      public string Number { get; set; }
     public DateTime PaidDate { get; set; } //data de pagamento
     public DateTime ExpireDate { get; set; }
     public decimal Total { get; set; }
     public decimal TotalPaid { get; set; }
     public string document { get; set; }
     public string Payer { get; set; }
     public string Address { get; set; } //endereço de cobrança
     public string Email { get; set; }
   }

   public class BoletoPayment : Payment
   {
     public string BarCode { get; set; }
     public string BoletoNumber { get; set; }
   }

   public class CreditCardPayment : Payment
   {
      //nunca armazenar cvv nem data por causa de processos por vazamento
     public string CardHolderName { get; set; } //titular do cartão
     public string CardNumber { get; set; } //os 4 ultimos digitos
     public string LastTransactionNumber { get; set; }
   }

   public class PayPalPayment :Payment
   {
      public string TransactionCode { get; set; }
   }
}