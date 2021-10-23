using Financeasy.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Financeasy.Infrastructure.Data.Mappings
{
    public class ProjectMap : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable(nameof(Project));
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