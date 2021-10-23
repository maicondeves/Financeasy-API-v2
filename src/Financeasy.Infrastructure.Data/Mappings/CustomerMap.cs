using Financeasy.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeasy.Infrastructure.Data.Mappings
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
               .HasColumnName("Name")
               .HasColumnType("varchar")
               .HasMaxLength(100)
               .IsRequired();

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