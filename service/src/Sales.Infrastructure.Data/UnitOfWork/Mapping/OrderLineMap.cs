namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Domain.ShoppingCart.Aggregates.OrderAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OrderLineMap : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder
                .HasKey(k => k.Id);
        }
    }
}