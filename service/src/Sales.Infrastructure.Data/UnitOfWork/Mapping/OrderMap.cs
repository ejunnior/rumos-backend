namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Domain.ShoppingCart.Aggregates.OrderAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OrderMap
        : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .HasKey(k => k.Id);
        }
    }
}