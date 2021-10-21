using System;
using Financeasy.Business.Core;
using Financeasy.Business.Validations;

namespace Financeasy.Business.Entities
{
    public class Customer : Entity
    {
        public string Name { get; private set; }

        public string Cpf { get; private set; }
        public string Cnpj { get; private set; }

        public string Email { get; private set; }
        public string HomePhone { get; private set; }
        public string CommercialPhone { get; private set; }
        public string CellPhone { get; private set; }

        public string Cep { get; private set; }
        public string StreetAddress { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        protected override void Validate() => Validate(new CustomerValidation(), this);

        protected void ValidateAddress() => Validate(new CustomerAddressValidation(), this);

        protected void ValidateContact() => Validate(new CustomerContactValidation(), this);

        public Customer()
        {
        }

        public Customer(string name, string cpf, string cnpj, string email, Guid userId)
        {
            Name = name;
            Cpf = cpf;
            Cnpj = cnpj;
            Email = email;
            UserId = userId;

            Validate();
        }

        public void ChangeAddress(string cep, string streetAddress, string complement, string district, string city, string state)
        {
            Cep = cep;
            StreetAddress = streetAddress;
            Complement = complement;
            District = district;
            City = city;
            State = state;

            ValidateAddress();
        }

        public void ChangeContact(string homePhone, string commercialPhone, string cellPhone)
        {
            HomePhone = homePhone;
            CommercialPhone = commercialPhone;
            CellPhone = cellPhone;

            ValidateContact();
        }
    }
}