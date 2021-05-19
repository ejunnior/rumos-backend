namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Domain.ShoppingCart.Aggregates.CustomerAggregate;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .HasKey(k => k.Id);

            builder
                .Property(p => p.Identification)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar");

            builder
                .Property(p => p.PostalCode)
                .IsRequired()
                .HasMaxLength(7)
                .HasColumnType("char");
        }
    }
}