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

            builder.Property(e => e.Created).HasColumnName("Created").HasColumnType("datetime").IsRequired();
            builder.Property(e => e.Updated).HasColumnName("Updated").HasColumnType("datetime");

            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("varchar").HasMaxLength(30).IsRequired();
            builder.Property(x => x.Description).HasColumnName("Description").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Status).HasColumnName("Status").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.StartDate).HasColumnName("StartDate").HasColumnType("date");
            builder.Property(x => x.ConclusionDate).HasColumnName("ConclusionDate").HasColumnType("date");

            builder.Property(x => x.CEP).HasColumnName("CEP").HasColumnType("varchar").HasMaxLength(14).IsRequired();
            builder.Property(x => x.StreetAddress).HasColumnName("StreetAddress").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Complement).HasColumnName("Complement").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.District).HasColumnName("District").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.City).HasColumnName("City").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.State).HasColumnName("State").HasColumnType("varchar").HasMaxLength(2).IsRequired();

            builder.Property(x => x.CustomerId).HasColumnName("CustomerId").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(x => x.Customer).WithMany().HasForeignKey(x => x.CustomerId);

            builder.Property(x => x.CategoryId).HasColumnName("CategoryId").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId);

            builder.Property(x => x.UserId).HasColumnName("UserId").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.Revenues).WithOne().HasForeignKey(x => x.Id);
            builder.HasMany(x => x.Expenses).WithOne().HasForeignKey(x => x.Id);
        }
    }
}