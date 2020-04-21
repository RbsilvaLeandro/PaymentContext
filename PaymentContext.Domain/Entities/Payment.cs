using System;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entity;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Adress adress, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = DateTime.Now;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Adress = adress;

            AddNotifications(new Contract()
            .Requires()
            .IsLowerOrEqualsThan(0,Total, "Payment.Total","O totak não pode ser zero")
            .IsGreaterOrEqualsThan(Total,TotalPaid,"Payment.TotalPaid","O valor deve ser menor que o pagamento")
            );

        }

        public string Number { get; private set; }
      
       public DateTime ExpireDate { get; private set; }
       public DateTime PaidDate { get; private set; }
       public decimal Total { get; private set; }
       public decimal TotalPaid { get; private set; }
       public string Payer { get; private set; }
       public Document Document { get; private set; }
       public Adress Adress { get; private set; }
       public Email Email { get; private set; }
    }
}