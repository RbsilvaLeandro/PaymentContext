using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjetcs
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

           AddNotifications(new Contract()
             .Requires()             
             .HasMinLen(FirstName,3,"Name.FirstName","O nome deve conter pelo menos 3 caracteres")
             .HasMinLen(LastName,3,"Name.LastName","O sobrenome deve conter pelo menos 3 caracteres")
             .HasMaxLen(FirstName,40,"Name.FirstName","O nomde deve conter nomáximo 40 caracteres") 
             .HasMaxLen(LastName,40,"Name.LastName","O nomde deve conter nomáximo 40 caracteres")            
           ) ;
        }

        public string  FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}