using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Financeasy.Business.Entities;

namespace Financeasy.Infrastructure.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
               .HasColumnName("Name")
               .HasColumnType("varchar")
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Password)
                .HasColumnName("Password")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Status)
                .HasColumnName("Status")
                .HasColumnType("smallint");

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