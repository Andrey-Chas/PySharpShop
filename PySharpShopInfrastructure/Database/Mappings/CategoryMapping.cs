using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PySharpShopApplication.Models;

namespace PySharpShopInfrastructure.Database.Mappings
{
    public sealed class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("category", "dbo");

            builder.HasKey(e => e.Id).HasName("id");

            builder.Property(e => e.Name)
                .HasColumnName("name")
                .HasColumnType("varchar")
                .HasMaxLength(254)
                .IsRequired();

            builder.HasMany(e => e.Products)
                .WithOne(e => e.Category);

            builder.HasIndex(e => e.Name)
                .IsUnique();
        }
    }
}
