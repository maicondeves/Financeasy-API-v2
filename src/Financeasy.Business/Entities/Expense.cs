using System;
using Financeasy.Business.Core;
using Financeasy.Business.Enumerators;

namespace Financeasy.Business.Entities
{
    public class Expense : Entity
    {
        public string Description { get; set; }
        public ExpenseStatus Status { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Amount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public Month MonthPeriod { get; set; }
        public short YearPeriod { get; set; }

        public DateTime RegisterDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public long ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public long UserId { get; set; }

        public virtual User User { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}