namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(k => k.Id);

            builder
                .HasMany(p => p.Addresses)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade)
                .Metadata.PrincipalToDependent.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Property(p => p.CustomerName)
                .HasConversion(p => p.Value,
                    p => CustomerName.Create(p).Value)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnType("varchar");
        }
    }
}