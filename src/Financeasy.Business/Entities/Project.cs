using System;
using System.Collections.Generic;
using Financeasy.Business.Core;
using Financeasy.Business.Enumerators;

namespace Financeasy.Business.Entities
{
    public class Project : Entity
    {
        public string Name { get; private set; }
        public string Description { get; set; }
        public ProjectStatus Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ConclusionDate { get; set; }

        public string CEP { get; set; }
        public string StreetAddress { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public DateTime RegisterDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Revenue> Revenues { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }

        public long CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

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