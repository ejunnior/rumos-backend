namespace Sales.Infrastructure.Data.UnitOfWork.Mapping
{
    using Domain.Profile.Aggregates.User;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AdministratorMap : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            //builder
            //    .HasKey(p => p.Id);
            builder.ToTable("Administrator");
        }
    }
}