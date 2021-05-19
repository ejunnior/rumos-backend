namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Domain.ShoppingCart.Aggregates.CartItemAggregate;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CartItemMap : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .HasOne<Product>(p => p.Product);
        }
    }
}