using Financeasy.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeasy.Infrastructure.Data.Mappings
{
    public class RevenueMap : IEntityTypeConfiguration<Revenue>
    {
        public void Configure(EntityTypeBuilder<Revenue> builder)
        {
            builder.ToTable(nameof(Revenue));
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