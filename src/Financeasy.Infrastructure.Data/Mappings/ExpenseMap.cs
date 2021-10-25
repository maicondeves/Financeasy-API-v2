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

            builder.Property(e => e.Created).HasColumnName("Created").HasColumnType("datetime").IsRequired();
            builder.Property(e => e.Updated).HasColumnName("Updated").HasColumnType("datetime");

            builder.Property(x => x.Description).HasColumnName("Description").HasColumnType("varchar").HasMaxLength(30).IsRequired();
            builder.Property(x => x.Status).HasColumnName("Status").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.ExpirationDate).HasColumnName("ExpirationDate").HasColumnType("date").IsRequired();
            builder.Property(x => x.Amount).HasColumnName("Amount").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.PaymentAmount).HasColumnName("PaymentAmount").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.PaymentDate).HasColumnName("PaymentDate").HasColumnType("date");
            builder.Property(x => x.MonthPeriod).HasColumnName("MonthPeriod").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.YearPeriod).HasColumnName("YearPeriod").HasColumnType("smallint").IsRequired();

            builder.Property(x => x.ProjectId).HasColumnName("ProjectId").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(x => x.Project).WithMany().HasForeignKey(x => x.ProjectId);

            builder.Property(x => x.CategoryId).HasColumnName("CategoryId").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId);

            builder.Property(x => x.UserId).HasColumnName("UserId").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
        }
    }
}