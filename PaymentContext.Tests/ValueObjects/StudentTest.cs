using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.ValueObjetcs;


namespace PaymentContext.Tests
{    
    [TestClass]
    public class StudentTests
    {
        private readonly Name _name;
        private readonly Document _document;
        private readonly Adress _adress;
        private readonly Email _email;
        private readonly Student _student;
        private readonly Subscription _subscription;

        public  StudentTests()
        {
           _name = new Name("Bruce","Wayne");
           _document = new Document("31558508848",EDocumentType.CPF);
           _adress = new Adress("Rua 1","1254","Bairro Legal","Gotam","SP","BR","123456879");
           _email = new Email("batman@dc.com");
           _student = new Student(_name,_document,_email);
           _subscription = new Subscription(null);
           
        }

        //Red, Green, Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
        {           
           _student.AddSubscription(_subscription);           

           Assert.IsTrue(_student.Invalid); 
        }

        [TestMethod]
        public void ShouldReturnSucessHadNoActiveSubscription()
        {
           var payment = new PayPalPayment("12345678",DateTime.Now,DateTime.Now.AddDays(5),10,10,"Wayne Corp",_document,_adress,_email);

           _subscription.addPayment(payment);
           _student.AddSubscription(_subscription);
          
           Assert.IsTrue(_student.Valid); 
        } 

       

       
 
    }
}