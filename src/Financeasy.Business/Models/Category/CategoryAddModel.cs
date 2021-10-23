using Financeasy.Business.Enumerators;
using System;

namespace Financeasy.Business.Models
{
    public class CategoryAddModel
    {
        public string Name { get; set; }
        public CategoryType Type { get; set; }

        public Guid UserId { get; set; }
    }
}