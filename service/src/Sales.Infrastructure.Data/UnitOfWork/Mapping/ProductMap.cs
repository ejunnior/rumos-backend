namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Domain.ShoppingCart.Aggregates.ProductAggregate;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(k => k.Id);

            builder.Property(p => p.ProductName)
                .HasConversion(p => p.Value,
                    p => ProductName.Create(p).Value)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnType("varchar");
        }
    }
}