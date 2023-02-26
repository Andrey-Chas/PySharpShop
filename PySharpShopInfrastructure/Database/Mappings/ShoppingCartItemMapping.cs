using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PySharpShopApplication.Models;

namespace PySharpShopInfrastructure.Database.Mappings
{
    public sealed class ShoppingCartItemMapping : IEntityTypeConfiguration<ShoppingCartItem>
    {
        public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
        {
            builder.ToTable("shoppingCartItem", "dbo");

            builder.HasKey(e => e.Id).HasName("id");

            builder.Property(e => e.ProductId)
                .HasColumnName("product_id")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.Property(e => e.PriceId)
                .HasColumnName("price_id")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.Property(e => e.ShoppingCartId)
                .HasColumnName("shopping_cart_id")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.HasOne(e => e.Product)
                .WithOne(e => e.ShoppingCartItem)
                .HasForeignKey<ShoppingCartItem>(e => e.ProductId)
                .IsRequired();

            builder.HasOne(e => e.Price)
                .WithOne(e => e.ShoppingCartItem)
                .HasForeignKey<ShoppingCartItem>(e => e.PriceId)
                .IsRequired();

            builder.HasOne(e => e.ShoppingCart)
                .WithOne(e => e.ShoppingCartItem)
                .HasForeignKey<ShoppingCartItem>(e => e.ShoppingCartId)
                .IsRequired();
        }
    }
}
