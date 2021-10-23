using Financeasy.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeasy.Infrastructure.Data.Mappings
{
    public class ExpenseMap : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.ToTable(nameof(Expense));
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Created)
               .HasColumnName("Created")
               .HasColumnType("datetime")
               .IsRequired();

            builder.Property(e => e.Updated)
               .HasColumnName("Updated")
               .HasColumnType("datetime");
        }
    }
}