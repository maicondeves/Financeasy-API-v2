using Financeasy.Business.Core;
using Financeasy.Business.Enumerators;
using Financeasy.Business.Validations;
using System;
using System.Collections.Generic;

namespace Financeasy.Business.Entities
{
    public class Project : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public ProjectStatus Status { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? ConclusionDate { get; private set; }

        public string CEP { get; private set; }
        public string StreetAddress { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public virtual ICollection<Revenue> Revenues { get; private set; }
        public virtual ICollection<Expense> Expenses { get; private set; }

        public Guid CustomerId { get; private set; }
        public virtual Customer Customer { get; private set; }

        public Guid CategoryId { get; private set; }
        public virtual Category Category { get; private set; }

        public Guid UserId { get; private set; }
        public virtual User User { get; private set; }

        public Project()
        {
        }

        public Project(string name, string description, Guid customerId, Guid categoryId, Guid userId)
        {
            Name = name;
            Description = description;
            CustomerId = customerId;
            CategoryId = categoryId;
            UserId = userId;

            ValidateBase();
        }

        protected override void ValidateBase()
            => Validate(new ProjectValidation(), this);

        protected void ValidateAddress()
            => Validate(new ProjectAddressValidation(), this);

        public void ChangeAddress(string cEP, string streetAddress, string complement, string district, string city, string state)
        {
            CEP = cEP;
            StreetAddress = streetAddress;
            Complement = complement;
            District = district;
            City = city;
            State = state;

            ValidateAddress();
        }

        public void AddRevenue(Revenue revenue)
        {
            if (Revenues is null)
                Revenues = new List<Revenue>();

            Revenues.Add(revenue);
        }

        public void AddExpense(Expense expense)
        {
            if (Expenses is null)
                Expenses = new List<Expense>();

            Expenses.Add(expense);
        }

        public void RemoveRevenue(Revenue revenue)
            => Revenues.Remove(revenue);

        public void RemoveExpense(Expense expense)
            => Expenses.Remove(expense);
    }
}