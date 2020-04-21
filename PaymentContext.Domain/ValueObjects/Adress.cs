using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Adress : ValueObject
    {
        public Adress(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract()
               .Requires()             
               .HasMinLen(Street,3,"Adress.Street","O nome da rua deve conter pelo menos 3 caracteres")
               .HasMinLen(Neighborhood,3,"Adress.Neighborhood","O bairro deve conter pelo menos 3 caracteres")
               .HasMinLen(City,3,"Adress.City","A cidade deve conter pelo menos 3 caracteres")
               .HasMinLen(State,3,"Adress.State","O estado deve conter pelo menos 3 caracteres")
               .HasMinLen(Country,3,"Adress.Country","O país deve conter pelo menos 3 caracteres")

               .HasMaxLen(Street,40,"Adress.Street","O nome da rua deve conter no máximo 40 caracteres")
               .HasMaxLen(Neighborhood,40,"Adress.Neighborhood","O bairro deve conter no máximo 40 caracteres")
               .HasMaxLen(City,40,"Adress.City","A cidade deve conter no máximo 40 caracteres")
               .HasMaxLen(State,40,"Adress.State","O estado deve conter no máximo 40 caracteres")
               .HasMaxLen(Country,40,"Adress.Country","O país deve conter no máximo 40 caracteres")
            );
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        
    }
}