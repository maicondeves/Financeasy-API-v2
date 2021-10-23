using Financeasy.Business.Core;
using Financeasy.Business.Enumerators;
using Financeasy.Business.Validations;
using System;

namespace Financeasy.Business.Entities
{
    public class Expense : Entity
    {
        public string Description { get; private set; }
        public ExpenseStatus Status { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public decimal Amount { get; private set; }
        public decimal? PaymentAmount { get; private set; }
        public DateTime? PaymentDate { get; private set; }
        public Month MonthPeriod { get; private set; }
        public short YearPeriod { get; private set; }

        public Guid ProjectId { get; private set; }
        public virtual Project Project { get; private set; }

        public Guid CategoryId { get; private set; }
        public virtual Category Category { get; private set; }

        public Guid UserId { get; private set; }

        public virtual User User { get; private set; }

        public Expense()
        {
        }

        public Expense(string description, ExpenseStatus status, DateTime expirationDate, decimal amount, Month monthPeriod, short yearPeriod, Guid projectId, Guid categoryId, Guid userId)
        {
            Description = description;
            Status = status;
            ExpirationDate = expirationDate;
            Amount = amount;
            MonthPeriod = monthPeriod;
            YearPeriod = yearPeriod;
            ProjectId = projectId;
            CategoryId = categoryId;
            UserId = userId;

            ValidateBase();
        }

        protected override void ValidateBase() => Validate(new ExpenseValidation(), this);

        public void Pay(decimal paymentAmount)
        {
            PaymentAmount += paymentAmount;
            PaymentDate = DateTime.Now;
        }
    }
}