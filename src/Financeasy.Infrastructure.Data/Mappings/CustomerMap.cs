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

            builder.Property(e => e.Created).HasColumnName("Created").HasColumnType("datetime").IsRequired();
            builder.Property(e => e.Updated).HasColumnName("Updated").HasColumnType("datetime");

            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("varchar").HasMaxLength(30).IsRequired();
            builder.Property(x => x.Cpf).HasColumnName("CPF").HasColumnType("varchar").HasMaxLength(14).IsRequired();
            builder.Property(x => x.Cnpj).HasColumnName("CNPJ").HasColumnType("varchar").HasMaxLength(18).IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("varchar").HasMaxLength(200).IsRequired();
            builder.Property(x => x.HomePhone).HasColumnName("HomePhone").HasColumnType("varchar").HasMaxLength(15).IsRequired();
            builder.Property(x => x.CommercialPhone).HasColumnName("CommercialPhone").HasColumnType("varchar").HasMaxLength(15).IsRequired();
            builder.Property(x => x.CellPhone).HasColumnName("CellPhone").HasColumnType("varchar").HasMaxLength(15).IsRequired();
            builder.Property(x => x.Cep).HasColumnName("CEP").HasColumnType("varchar").HasMaxLength(14).IsRequired();
            builder.Property(x => x.StreetAddress).HasColumnName("StreetAddress").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Complement).HasColumnName("Complement").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            builder.Property(x => x.District).HasColumnName("District").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.City).HasColumnName("City").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.State).HasColumnName("State").HasColumnType("varchar").HasMaxLength(2).IsRequired();

            builder.Property(x => x.UserId).HasColumnName("UserId").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
        }
    }
}