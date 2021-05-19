namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Domain.ShoppingCart.Aggregates.OrderAggregate;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OrderLineMap : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder
                .HasKey(k => k.Id);

            builder.Property(p => p.Quantity)
                .HasConversion(p => p.Value,
                    p => Quantity.Create(p).Value)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(p => p.UnitPrice)
                .HasConversion(p => p.Value,
                    p => UnitPrice.Create(p).Value)
                .IsRequired()
                .HasColumnType("decimal(7,2)");

            builder
                .HasOne<Product>(p => p.Product);
        }
    }
}