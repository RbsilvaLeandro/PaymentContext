using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;


namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        //Red, Green, Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
           var doc = new Document("123", EDocumentType.CNPJ);
           Assert.IsTrue(doc.Invalid); 
        }

        [TestMethod]
        public void ShouldReturnSucessWhenCNPJIsvalid()
        {
           var doc = new Document("54485546000109", EDocumentType.CNPJ);
           Assert.IsTrue(doc.Valid);
        } 

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
           var doc = new Document("312",EDocumentType.CPF);
           Assert.IsTrue(doc.Invalid); 
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsvalid()
        {
           var doc = new Document("31558508848",EDocumentType.CPF);
           Assert.IsTrue(doc.Valid); 
        }
 
    }
}