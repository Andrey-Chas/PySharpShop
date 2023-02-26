using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PySharpShopApplication.Models;

namespace PySharpShopInfrastructure.Database.Mappings
{
    public sealed class ShoppingCartMapping : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.ToTable("shoppingCart", "dbo");

            builder.HasKey(e => e.Id).HasName("id");

            builder.Property(e => e.TotalPrice)
                .HasColumnName("total_price")
                .HasColumnType("REAL")
                .IsRequired();

            builder.Property(e => e.Currency)
                .HasColumnName("currency")
                .HasColumnType("TEXT")
                .HasMaxLength(3)
                .IsRequired();

            builder.Property(e => e.Status)
                .HasColumnName("status")
                .HasColumnType("INTEGER")
                .HasDefaultValue(ProductStatus.Inactive)
                .HasConversion<ProductStatus>();

            builder.HasMany(e => e.Items)
                .WithOne(e => e.ShoppingCart);
        }
    }
}
