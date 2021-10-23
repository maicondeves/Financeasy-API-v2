using Financeasy.Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Financeasy.Infrastructure.Data.Contexts
{
    public sealed class FinanceasyContext : DbContext
    {
        public FinanceasyContext(DbContextOptions<FinanceasyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ExpenseMap());
            modelBuilder.ApplyConfiguration(new RevenueMap());
            modelBuilder.ApplyConfiguration(new ProjectMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}