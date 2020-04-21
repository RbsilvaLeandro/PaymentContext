using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{   
   
    public class PayPalPayment: Payment
    {
        public PayPalPayment(
            string transactionCode,
            DateTime date, 
            DateTime expireDate, 
            decimal total, 
            decimal totalPaid, 
            string payer, 
            Document document, 
            Adress adress,
            Email email):base(
                date,
                expireDate,
                total,
                totalPaid,
                payer,
                document,
                adress,
                email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; set; }
    }
}