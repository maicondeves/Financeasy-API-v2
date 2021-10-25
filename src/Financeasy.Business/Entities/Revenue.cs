using Financeasy.Business.Core;
using Financeasy.Business.Enumerators;
using Financeasy.Business.Validations;
using System;

namespace Financeasy.Business.Entities
{
    public class Revenue : Entity
    {
        public string Description { get; private set; }
        public RevenueStatus Status { get; private set; }
        public decimal ReceivableAmount { get; private set; }
        public decimal ReceivedAmount { get; private set; }
        public DateTime? ReceivedDate { get; private set; }
        public Month MonthPeriod { get; private set; }
        public short YearPeriod { get; private set; }

        public Guid ProjectId { get; private set; }
        public virtual Project Project { get; private set; }

        public Guid CategoryId { get; private set; }
        public virtual Category Category { get; private set; }

        public Guid UserId { get; private set; }

        public virtual User User { get; private set; }

        public Revenue()
        {
        }

        public Revenue(string description, RevenueStatus status, decimal receivableAmount, Month monthPeriod, short yearPeriod, Guid projectId, Guid categoryId, Guid userId)
        {
            Description = description;
            Status = status;
            ReceivableAmount = receivableAmount;
            ReceivedAmount = 0;
            MonthPeriod = monthPeriod;
            YearPeriod = yearPeriod;
            ProjectId = projectId;
            CategoryId = categoryId;
            UserId = userId;

            ValidateBase();
        }

        protected override void ValidateBase() => Validate(new RevenueValidation(), this);

        public void Receive(decimal receivedAmount)
        {
            ReceivedAmount += receivedAmount;
            ReceivedDate = DateTime.Now;
        }
    }
}