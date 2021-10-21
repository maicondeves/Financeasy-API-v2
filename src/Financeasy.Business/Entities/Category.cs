using System;
using Financeasy.Business.Core;
using Financeasy.Business.Enumerators;
using Financeasy.Business.Validations;

namespace Financeasy.Business.Entities
{
    public class Category : Entity
    {
        public string Name { get; private set; }
        public CategoryType Type { get; private set; }

        public Guid UserId { get; private set; }

        public virtual User User { get; private set; }

        public Category()
        {
        }

        public Category(string name, CategoryType type, Guid userId)
        {
            Name = name;
            Type = type;
            UserId = userId;

            Validate();
        }

        protected override void Validate() => Validate(new CategoryValidation(), this);
    }
}